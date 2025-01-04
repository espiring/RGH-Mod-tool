namespace bo2_mod_tool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Connectionlabel = new Label();
            ConnectButton = new Button();
            SystemInfoLabel = new Label();
            TempCPU = new TextBox();
            TempGPU = new TextBox();
            TempMOB = new TextBox();
            GetConsoleInfo = new Button();
            SuspendLayout();
            // 
            // Connectionlabel
            // 
            Connectionlabel.AutoSize = true;
            Connectionlabel.Location = new Point(276, 38);
            Connectionlabel.Name = "Connectionlabel";
            Connectionlabel.Size = new Size(172, 15);
            Connectionlabel.TabIndex = 0;
            Connectionlabel.Text = "Current connection status: N/A";
            // 
            // ConnectButton
            // 
            ConnectButton.Location = new Point(295, 56);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(137, 42);
            ConnectButton.TabIndex = 1;
            ConnectButton.Text = "Connect to console";
            ConnectButton.UseVisualStyleBackColor = true;
            // 
            // SystemInfoLabel
            // 
            SystemInfoLabel.AutoSize = true;
            SystemInfoLabel.Location = new Point(295, 165);
            SystemInfoLabel.Name = "SystemInfoLabel";
            SystemInfoLabel.Size = new Size(116, 15);
            SystemInfoLabel.TabIndex = 2;
            SystemInfoLabel.Text = "Console information";
            // 
            // TempCPU
            // 
            TempCPU.Location = new Point(295, 197);
            TempCPU.Name = "TempCPU";
            TempCPU.Size = new Size(220, 23);
            TempCPU.TabIndex = 3;
            TempCPU.Text = "CPU temp: ";
            // 
            // TempGPU
            // 
            TempGPU.Location = new Point(295, 243);
            TempGPU.Name = "TempGPU";
            TempGPU.Size = new Size(220, 23);
            TempGPU.TabIndex = 4;
            TempGPU.Text = "GPU temp:";
            // 
            // TempMOB
            // 
            TempMOB.Location = new Point(295, 296);
            TempMOB.Name = "TempMOB";
            TempMOB.Size = new Size(220, 23);
            TempMOB.TabIndex = 5;
            TempMOB.Text = "Motherboard temp:";
            // 
            // GetConsoleInfo
            // 
            GetConsoleInfo.Location = new Point(307, 366);
            GetConsoleInfo.Name = "GetConsoleInfo";
            GetConsoleInfo.Size = new Size(171, 23);
            GetConsoleInfo.TabIndex = 6;
            GetConsoleInfo.Text = "Get console info";
            GetConsoleInfo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GetConsoleInfo);
            Controls.Add(TempMOB);
            Controls.Add(TempGPU);
            Controls.Add(TempCPU);
            Controls.Add(SystemInfoLabel);
            Controls.Add(ConnectButton);
            Controls.Add(Connectionlabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Connectionlabel;
        private Button ConnectButton;
        private Label SystemInfoLabel;
        private TextBox TempCPU;
        private TextBox TempGPU;
        private TextBox TempMOB;
        private Button GetConsoleInfo;
    }
}
