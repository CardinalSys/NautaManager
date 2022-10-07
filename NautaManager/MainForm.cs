using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NautaManager
{
    public partial class MainForm : Form
    {
        //Visuals

        //Move form without borders
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0X2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //Curve borders
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );


        //Variables
        private string username;
        private string password;
        private string passwordEncrypted;
        private bool connected = false;
        private string onlineTime;
        private string aviableTime;
        private int timerMins;
        private bool timerAct = false;




        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);
        private const int BM_CLICK = 0xF5;
        private const uint WM_ACTIVATE = 0x6;
        private const int WA_ACTIVE = 1;

        public MainForm()
        {
            InitializeComponent();

            SetBanner(); //Get the nauta portal banner

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); //Round the bordes

            //Check if exist a save file 
            if (File.Exists(Directory.GetCurrentDirectory() + @"\user.dat"))
            {
                GetUserPass();
                password = (Decrypt(passwordEncrypted));
                UserTextBox.Text = username;
                PassTextBox.Text = password;
            }

        }


        //Acepta la ventana emergente que sale al tratar de desconectarte
        public void ActivateAndClickOkButton()
        {
            // find dialog window with titlebar text of "Message from webpage"

            var hwnd = FindWindow("#32770", "Message from webpage"); //Mensaje de página web
            if (hwnd != IntPtr.Zero)
            {
                // find button on dialog window: classname = "Button", text = "OK"
                var btn = FindWindowEx(hwnd, IntPtr.Zero, "Button", "Ok"); //Aceptar
                if (btn != IntPtr.Zero)
                {
                    // activate the button on dialog first or it may not acknowledge a click msg on first try
                    SendMessage(btn, WM_ACTIVATE, WA_ACTIVE, 0);

                    // send button a click message
                    SendMessage(btn, BM_CLICK, 0, 0);
                }
                else
                    MessageBox.Show("¡Botón no encontrado!");
            }

        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void PassTextBox_TextChanged(object sender, EventArgs e) { PassTextBox.UseSystemPasswordChar = true; }
 
        private void GetUserPass()
        {
            StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + @"\user.dat");
            string stringText = reader.ReadToEnd();
            reader.Close();
            string[] stringTextArray = stringText.Split(';');
            username = stringTextArray[0].Replace("username: ", "");
            passwordEncrypted = stringTextArray[1].Replace("password: ", "");
        }


        private void UserTextBox_Click(object sender, EventArgs e)
        {
            if (UserTextBox.Text == "Usuario...")
                UserTextBox.Text = "";
        }

        private void PassTextBox_Click(object sender, EventArgs e)
        {
            if (PassTextBox.Text == "Contraseña...")
                PassTextBox.Text = "";
        }
        private void Ui(bool activated)
        {
            UserTextBox.Visible = activated;
            PassTextBox.Visible = activated;
            ConnectButton.Visible = activated;
            UserText.Visible = activated;
            PassText.Visible = activated;
            RemTime.Visible = !activated;
            DisconnectButton.Visible = !activated;
            ConnectedTimeText.Visible = !activated;
            AviableTimeText.Visible = !activated;

        }

        //Buttons
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (UserTextBox.Text.Contains("@nauta.com.cu") || UserTextBox.Text.Contains("@nautaplus"))
            {
                //If the text inputted is different than the saved ask for save it
                if (username != UserTextBox.Text || password != PassTextBox.Text)
                {
                    DialogResult dialog = MessageBox.Show("¿Deseas guardar tu usuario y contraseña?", "Aviso", MessageBoxButtons.YesNo);

                    if (dialog == DialogResult.Yes)
                    {
                        if(File.Exists(Directory.GetCurrentDirectory() + @"\user.dat"))
                        {
                            File.Delete(Directory.GetCurrentDirectory() + @"\user.dat");
                        }
                        StreamWriter write = new StreamWriter(Directory.GetCurrentDirectory() + @"\user.dat");
                        string strEncrypted = (Encrypt(PassTextBox.Text));
                        write.Write("username: " + UserTextBox.Text + ";" + "password: " + strEncrypted);
                        write.Close();
                    }
                }
                Login();
            }
            else
                MessageBox.Show("Formato de Usuario incorrecto, revise si @nauta.com.cu o @nautaplus está bien escrito.");
        }

        private void StartTimer_Click(object sender, EventArgs e)
        {
            if (MinLimit.Text == "")
            {
                MinLimit.Text = "0";
            }
            if (Int32.Parse(MinLimit.Text) >= 59)
            {
                MinLimit.Text = "59";
            }
            if (HourLimit.Text == "")
            {
                HourLimit.Text = "0";
            }
            timerMins = Int32.Parse(MinLimit.Text) + (Int32.Parse(HourLimit.Text) * 60);
            timerAct = true;
            ReduceTime.Enabled = true;
        }

        private void DisconnectButton_Click(object sender, EventArgs e) { Logout(); }

        private void ExitButton_Click(object sender, EventArgs e) { Exit(); }


        private void MinButton_Click(object sender, EventArgs e) { WindowState = FormWindowState.Minimized; }



        //Timers

        private void MainTimer_Tick(object sender, EventArgs e) { Main(); }

        private void ReduceTime_Tick(object sender, EventArgs e) { timerMins -= 1; }

        private void ClickOnWindows_Tick(object sender, EventArgs e) { ActivateAndClickOkButton(); }

    }

    

   
}
