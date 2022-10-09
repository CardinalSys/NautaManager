
namespace NautaManager
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ExitButton = new System.Windows.Forms.Button();
            this.MinButton = new System.Windows.Forms.Button();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.ConnectedTimeText = new System.Windows.Forms.Label();
            this.AviableTimeText = new System.Windows.Forms.Label();
            this.NautaBanner = new System.Windows.Forms.PictureBox();
            this.PassText = new System.Windows.Forms.Label();
            this.UserText = new System.Windows.Forms.Label();
            this.TimerDisconnect = new System.Windows.Forms.Label();
            this.RemTime = new System.Windows.Forms.Label();
            this.HourLimit = new System.Windows.Forms.TextBox();
            this.MinLimit = new System.Windows.Forms.TextBox();
            this.HLimitText = new System.Windows.Forms.Label();
            this.MLimitText = new System.Windows.Forms.Label();
            this.ActiveTimerBtm = new System.Windows.Forms.Button();
            this.ReduceTime = new System.Windows.Forms.Timer(this.components);
            this.ClickOnWindows = new System.Windows.Forms.Timer(this.components);
            this.ReconnectCheckBox = new System.Windows.Forms.CheckBox();
            this.SpeedTestBtm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NautaBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitButton.Location = new System.Drawing.Point(978, -1);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(22, 23);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MinButton
            // 
            this.MinButton.FlatAppearance.BorderSize = 0;
            this.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MinButton.Location = new System.Drawing.Point(932, -16);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(31, 38);
            this.MinButton.TabIndex = 1;
            this.MinButton.Text = "_";
            this.MinButton.UseVisualStyleBackColor = true;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(498, 263);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(207, 20);
            this.UserTextBox.TabIndex = 4;
            this.UserTextBox.Text = "Usuario...";
            this.UserTextBox.Click += new System.EventHandler(this.UserTextBox_Click);
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(498, 321);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(207, 20);
            this.PassTextBox.TabIndex = 5;
            this.PassTextBox.Text = "Contraseña...";
            this.PassTextBox.Click += new System.EventHandler(this.PassTextBox_Click);
            this.PassTextBox.TextChanged += new System.EventHandler(this.PassTextBox_TextChanged);
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(560, 378);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 7;
            this.ConnectButton.Text = "Conectar";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(545, 378);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(100, 23);
            this.DisconnectButton.TabIndex = 9;
            this.DisconnectButton.Text = "Desconectar";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Visible = false;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // ConnectedTimeText
            // 
            this.ConnectedTimeText.BackColor = System.Drawing.Color.Transparent;
            this.ConnectedTimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.ConnectedTimeText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ConnectedTimeText.Location = new System.Drawing.Point(498, 228);
            this.ConnectedTimeText.Name = "ConnectedTimeText";
            this.ConnectedTimeText.Size = new System.Drawing.Size(207, 32);
            this.ConnectedTimeText.TabIndex = 10;
            this.ConnectedTimeText.Text = "Tiempo consumido:";
            this.ConnectedTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ConnectedTimeText.Visible = false;
            // 
            // AviableTimeText
            // 
            this.AviableTimeText.BackColor = System.Drawing.Color.Transparent;
            this.AviableTimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.AviableTimeText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AviableTimeText.Location = new System.Drawing.Point(498, 286);
            this.AviableTimeText.Name = "AviableTimeText";
            this.AviableTimeText.Size = new System.Drawing.Size(207, 32);
            this.AviableTimeText.TabIndex = 11;
            this.AviableTimeText.Text = "Tiempo disponible:";
            this.AviableTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AviableTimeText.Visible = false;
            // 
            // NautaBanner
            // 
            this.NautaBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NautaBanner.Location = new System.Drawing.Point(227, 46);
            this.NautaBanner.Name = "NautaBanner";
            this.NautaBanner.Size = new System.Drawing.Size(770, 138);
            this.NautaBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NautaBanner.TabIndex = 12;
            this.NautaBanner.TabStop = false;
            // 
            // PassText
            // 
            this.PassText.AutoSize = true;
            this.PassText.BackColor = System.Drawing.Color.Transparent;
            this.PassText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.PassText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PassText.Location = new System.Drawing.Point(495, 300);
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(89, 18);
            this.PassText.TabIndex = 13;
            this.PassText.Text = "Contraseña:";
            this.PassText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserText
            // 
            this.UserText.AutoSize = true;
            this.UserText.BackColor = System.Drawing.Color.Transparent;
            this.UserText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.UserText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UserText.Location = new System.Drawing.Point(495, 242);
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(64, 18);
            this.UserText.TabIndex = 14;
            this.UserText.Text = "Usuario:";
            this.UserText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerDisconnect
            // 
            this.TimerDisconnect.AutoSize = true;
            this.TimerDisconnect.BackColor = System.Drawing.Color.Transparent;
            this.TimerDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerDisconnect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TimerDisconnect.Location = new System.Drawing.Point(40, 283);
            this.TimerDisconnect.Name = "TimerDisconnect";
            this.TimerDisconnect.Size = new System.Drawing.Size(133, 25);
            this.TimerDisconnect.TabIndex = 15;
            this.TimerDisconnect.Text = "Temporizador";
            // 
            // RemTime
            // 
            this.RemTime.AutoSize = true;
            this.RemTime.BackColor = System.Drawing.Color.Transparent;
            this.RemTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RemTime.Location = new System.Drawing.Point(14, 403);
            this.RemTime.Name = "RemTime";
            this.RemTime.Size = new System.Drawing.Size(16, 17);
            this.RemTime.TabIndex = 16;
            this.RemTime.Text = "a";
            this.RemTime.Visible = false;
            // 
            // HourLimit
            // 
            this.HourLimit.Location = new System.Drawing.Point(68, 321);
            this.HourLimit.Name = "HourLimit";
            this.HourLimit.Size = new System.Drawing.Size(32, 20);
            this.HourLimit.TabIndex = 17;
            // 
            // MinLimit
            // 
            this.MinLimit.Location = new System.Drawing.Point(130, 321);
            this.MinLimit.Name = "MinLimit";
            this.MinLimit.Size = new System.Drawing.Size(32, 20);
            this.MinLimit.TabIndex = 18;
            // 
            // HLimitText
            // 
            this.HLimitText.BackColor = System.Drawing.Color.Transparent;
            this.HLimitText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HLimitText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HLimitText.Location = new System.Drawing.Point(46, 320);
            this.HLimitText.Name = "HLimitText";
            this.HLimitText.Size = new System.Drawing.Size(19, 25);
            this.HLimitText.TabIndex = 19;
            this.HLimitText.Text = "H";
            // 
            // MLimitText
            // 
            this.MLimitText.BackColor = System.Drawing.Color.Transparent;
            this.MLimitText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLimitText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MLimitText.Location = new System.Drawing.Point(106, 321);
            this.MLimitText.Name = "MLimitText";
            this.MLimitText.Size = new System.Drawing.Size(19, 25);
            this.MLimitText.TabIndex = 20;
            this.MLimitText.Text = "M";
            // 
            // ActiveTimerBtm
            // 
            this.ActiveTimerBtm.Enabled = false;
            this.ActiveTimerBtm.Location = new System.Drawing.Point(68, 358);
            this.ActiveTimerBtm.Name = "ActiveTimerBtm";
            this.ActiveTimerBtm.Size = new System.Drawing.Size(75, 23);
            this.ActiveTimerBtm.TabIndex = 21;
            this.ActiveTimerBtm.Text = "Iniciar";
            this.ActiveTimerBtm.UseVisualStyleBackColor = true;
            this.ActiveTimerBtm.Click += new System.EventHandler(this.StartTimer_Click);
            // 
            // ReduceTime
            // 
            this.ReduceTime.Interval = 60000;
            this.ReduceTime.Tick += new System.EventHandler(this.ReduceTime_Tick);
            // 
            // ClickOnWindows
            // 
            this.ClickOnWindows.Tick += new System.EventHandler(this.ClickOnWindows_Tick);
            // 
            // ReconnectCheckBox
            // 
            this.ReconnectCheckBox.AutoSize = true;
            this.ReconnectCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.ReconnectCheckBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ReconnectCheckBox.Location = new System.Drawing.Point(516, 422);
            this.ReconnectCheckBox.Name = "ReconnectCheckBox";
            this.ReconnectCheckBox.Size = new System.Drawing.Size(153, 17);
            this.ReconnectCheckBox.TabIndex = 26;
            this.ReconnectCheckBox.Text = "Reconectar cada 12 horas";
            this.ReconnectCheckBox.UseVisualStyleBackColor = false;
            // 
            // SpeedTestBtm
            // 
            this.SpeedTestBtm.Enabled = false;
            this.SpeedTestBtm.Location = new System.Drawing.Point(68, 203);
            this.SpeedTestBtm.Name = "SpeedTestBtm";
            this.SpeedTestBtm.Size = new System.Drawing.Size(75, 23);
            this.SpeedTestBtm.TabIndex = 27;
            this.SpeedTestBtm.Text = "Comprobar";
            this.SpeedTestBtm.UseVisualStyleBackColor = true;
            this.SpeedTestBtm.Click += new System.EventHandler(this.SpeedTestBtm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Calidad de conexión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(938, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "by Cardinal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(26, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Herramientas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::NautaManager.Properties.Resources.Github;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(932, 394);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 59);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::NautaManager.Properties.Resources.BGNauta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 465);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpeedTestBtm);
            this.Controls.Add(this.ReconnectCheckBox);
            this.Controls.Add(this.ActiveTimerBtm);
            this.Controls.Add(this.MLimitText);
            this.Controls.Add(this.HLimitText);
            this.Controls.Add(this.MinLimit);
            this.Controls.Add(this.HourLimit);
            this.Controls.Add(this.RemTime);
            this.Controls.Add(this.TimerDisconnect);
            this.Controls.Add(this.UserText);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.NautaBanner);
            this.Controls.Add(this.AviableTimeText);
            this.Controls.Add(this.ConnectedTimeText);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.MinButton);
            this.Controls.Add(this.ExitButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Nauta Manager";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.NautaBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MinButton;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Label ConnectedTimeText;
        private System.Windows.Forms.Label AviableTimeText;
        private System.Windows.Forms.PictureBox NautaBanner;
        private System.Windows.Forms.Label PassText;
        private System.Windows.Forms.Label UserText;
        private System.Windows.Forms.Label TimerDisconnect;
        private System.Windows.Forms.Label RemTime;
        private System.Windows.Forms.TextBox HourLimit;
        private System.Windows.Forms.TextBox MinLimit;
        private System.Windows.Forms.Label HLimitText;
        private System.Windows.Forms.Label MLimitText;
        private System.Windows.Forms.Button ActiveTimerBtm;
        private System.Windows.Forms.Timer ReduceTime;
        private System.Windows.Forms.Timer ClickOnWindows;
        private System.Windows.Forms.CheckBox ReconnectCheckBox;
        private System.Windows.Forms.Button SpeedTestBtm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

