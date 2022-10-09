using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NautaManager
{
    public partial class MainForm //Web
    {
        //WebBrowers
        WebBrowser webBrowser;
        HtmlElement aviableTimeElement;
        HtmlElement onlineTimeElement;
        private void Main()
        {

            //Check if the user and pass are different that the default text for enable the connect button
            if (UserTextBox.Text == "" || UserTextBox.Text == "Usuario..." || PassTextBox.Text == "" || PassTextBox.Text == "Contraseña...")
                ConnectButton.Enabled = false;
            else
                ConnectButton.Enabled = true;


            if (connected == true)
            {

                ActiveTimerBtm.Enabled = true; //Enable the timer start button
                SpeedTestBtm.Enabled = true;

                if (onlineTimeElement != null) //Get current connected time
                {
                    onlineTime = onlineTimeElement.InnerHtml;
                    ConnectedTimeText.Text = "Tiempo consumido: " + onlineTime;
                    try
                    {
                        if (onlineTime.Split(':')[0] == "12")
                        {
                            Logout();
                            Login();
                        }
                    }catch (Exception ex) { }

                }
                else
                {
                    onlineTimeElement = webBrowser.Document.GetElementById("onlineTime");
                    ConnectedTimeText.Text = "NUll";
                }



                if (aviableTimeElement != null) //Get aviable time
                {
                    aviableTime = aviableTimeElement.InnerHtml;
                    AviableTimeText.Text = "Tiempo disponible: " + aviableTime;
                }
                else
                    aviableTimeElement = webBrowser.Document.GetElementById("availableTime");



                //If the timer time reaches 0 disconnet the account
                if (timerMins == 0 && timerAct)
                {
                    timerAct = false;
                    ClickOnWindows.Enabled = true;
                    Logout();
                    MessageBox.Show("Cuenta desconectada", "Aviso", MessageBoxButtons.OK);
                }

                RemTime.Text = "Tiempo Restante: " + timerMins.ToString() + " minutos";


            }
            else
            {
                ActiveTimerBtm.Enabled = false;
                SpeedTestBtm.Enabled = false;
            }
        }

        private void SetBanner() { NautaBanner.ImageLocation = "https://secure.etecsa.net:8443/nauta_hogar/LoginURL/images/banner_hogar.png"; }

        private void Login()
        {
            webBrowser = new WebBrowser();
            webBrowser.Navigate("https://secure.etecsa.net:8443");

            webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser_DocumentCompleted);

            void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
            {
                HtmlElementCollection elems = webBrowser.Document.GetElementsByTagName("input"); 
                                                                                                 
                foreach (HtmlElement elem in elems)
                {
                    string type = elem.GetAttribute("type");
                    if (!string.IsNullOrEmpty(type) && type == "button" && elem.GetAttribute("value") == "Aceptar")
                    {
                        //Set the values in the web browser
                        HtmlElement user = webBrowser.Document.GetElementById("username");
                        user.SetAttribute("value", UserTextBox.Text);
                        HtmlElement pass = webBrowser.Document.GetElementById("password");
                        pass.SetAttribute("value", PassTextBox.Text);

                        Ui(false); //Disable the first UI

                        elem.InvokeMember("click");
                        connected = true;
                        break;
                    }
                }
            }
        }

        void Logout()
        {
            HtmlElementCollection elems = webBrowser.Document.GetElementsByTagName("input");

            foreach (HtmlElement elem in elems)
            {
                string type = elem.GetAttribute("type");
                if (!string.IsNullOrEmpty(type) && type == "button" && elem.Name == "logout")
                {
                    elem.InvokeMember("click");
                    aviableTimeElement = null;
                    onlineTimeElement = null;
                    connected = false;
                    Ui(true);
                    ClickOnWindows.Enabled = false;
                    break;
                }
            }
        }

        void Exit()
        {
            if (connected)
            {
                DialogResult dialog = MessageBox.Show("¿Deseas desconectar su cuenta?", "Aviso", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    Logout();

                    DialogResult dialog1 = MessageBox.Show("Cuenta desconectada", "Aviso", MessageBoxButtons.OK);
                    if (dialog1 == DialogResult.OK)
                        Application.Exit();
                }
                else
                    Application.Exit();
            }
            else
                Application.Exit();
        }

       
    }
}
