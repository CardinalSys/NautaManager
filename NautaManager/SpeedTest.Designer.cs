namespace NautaManager
{
    partial class SpeedTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.DownloadText = new System.Windows.Forms.Label();
            this.UploadText = new System.Windows.Forms.Label();
            this.LatencyText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calidad de conexión";
            // 
            // DownloadText
            // 
            this.DownloadText.AutoSize = true;
            this.DownloadText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadText.Location = new System.Drawing.Point(38, 120);
            this.DownloadText.Name = "DownloadText";
            this.DownloadText.Size = new System.Drawing.Size(78, 20);
            this.DownloadText.TabIndex = 1;
            this.DownloadText.Text = "Descarga";
            // 
            // UploadText
            // 
            this.UploadText.AutoSize = true;
            this.UploadText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadText.Location = new System.Drawing.Point(38, 165);
            this.UploadText.Name = "UploadText";
            this.UploadText.Size = new System.Drawing.Size(62, 20);
            this.UploadText.TabIndex = 2;
            this.UploadText.Text = "Sublida";
            // 
            // LatencyText
            // 
            this.LatencyText.AutoSize = true;
            this.LatencyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LatencyText.Location = new System.Drawing.Point(38, 210);
            this.LatencyText.Name = "LatencyText";
            this.LatencyText.Size = new System.Drawing.Size(70, 20);
            this.LatencyText.TabIndex = 3;
            this.LatencyText.Text = "Latencia";
            // 
            // SpeedTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(432, 326);
            this.Controls.Add(this.LatencyText);
            this.Controls.Add(this.UploadText);
            this.Controls.Add(this.DownloadText);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SpeedTest";
            this.Text = "SpeedTest";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label DownloadText;
        public System.Windows.Forms.Label UploadText;
        public System.Windows.Forms.Label LatencyText;
    }
}