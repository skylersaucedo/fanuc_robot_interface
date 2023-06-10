namespace fanuc_robot_interface
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnConnectToFeather = new System.Windows.Forms.Button();
            this.cmbxCOMS = new System.Windows.Forms.ComboBox();
            this.btnToggleLight = new System.Windows.Forms.Button();
            this.btnConnectToLaser = new System.Windows.Forms.Button();
            this.lblLaserVal = new System.Windows.Forms.Label();
            this.btnConnectToRobot = new System.Windows.Forms.Button();
            this.lblRobotStatus = new System.Windows.Forms.Label();
            this.lblConnectToCam = new System.Windows.Forms.Label();
            this.lblConnectToLights = new System.Windows.Forms.Label();
            this.txbxLaserVal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(247, 33);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "connect to camera";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnConnectToFeather
            // 
            this.btnConnectToFeather.Location = new System.Drawing.Point(12, 51);
            this.btnConnectToFeather.Name = "btnConnectToFeather";
            this.btnConnectToFeather.Size = new System.Drawing.Size(247, 29);
            this.btnConnectToFeather.TabIndex = 1;
            this.btnConnectToFeather.Text = "connect to lights";
            this.btnConnectToFeather.UseVisualStyleBackColor = true;
            this.btnConnectToFeather.Click += new System.EventHandler(this.btnConnectToFeather_Click);
            // 
            // cmbxCOMS
            // 
            this.cmbxCOMS.FormattingEnabled = true;
            this.cmbxCOMS.Location = new System.Drawing.Point(514, 52);
            this.cmbxCOMS.Name = "cmbxCOMS";
            this.cmbxCOMS.Size = new System.Drawing.Size(151, 28);
            this.cmbxCOMS.TabIndex = 2;
            // 
            // btnToggleLight
            // 
            this.btnToggleLight.Location = new System.Drawing.Point(685, 50);
            this.btnToggleLight.Name = "btnToggleLight";
            this.btnToggleLight.Size = new System.Drawing.Size(94, 29);
            this.btnToggleLight.TabIndex = 3;
            this.btnToggleLight.Text = "lights ON";
            this.btnToggleLight.UseVisualStyleBackColor = true;
            this.btnToggleLight.Click += new System.EventHandler(this.btnToggleLight_Click);
            // 
            // btnConnectToLaser
            // 
            this.btnConnectToLaser.Location = new System.Drawing.Point(12, 86);
            this.btnConnectToLaser.Name = "btnConnectToLaser";
            this.btnConnectToLaser.Size = new System.Drawing.Size(247, 29);
            this.btnConnectToLaser.TabIndex = 4;
            this.btnConnectToLaser.Text = "connect to laser";
            this.btnConnectToLaser.UseVisualStyleBackColor = true;
            this.btnConnectToLaser.Click += new System.EventHandler(this.btnConnectToLaser_Click);
            // 
            // lblLaserVal
            // 
            this.lblLaserVal.AutoSize = true;
            this.lblLaserVal.Location = new System.Drawing.Point(295, 90);
            this.lblLaserVal.Name = "lblLaserVal";
            this.lblLaserVal.Size = new System.Drawing.Size(196, 20);
            this.lblLaserVal.TabIndex = 5;
            this.lblLaserVal.Text = "NOT CONNECTED TO LASER";
            this.lblLaserVal.Click += new System.EventHandler(this.lblLaserVal_Click);
            // 
            // btnConnectToRobot
            // 
            this.btnConnectToRobot.Location = new System.Drawing.Point(12, 121);
            this.btnConnectToRobot.Name = "btnConnectToRobot";
            this.btnConnectToRobot.Size = new System.Drawing.Size(247, 29);
            this.btnConnectToRobot.TabIndex = 6;
            this.btnConnectToRobot.Text = "connect to robot";
            this.btnConnectToRobot.UseVisualStyleBackColor = true;
            this.btnConnectToRobot.Click += new System.EventHandler(this.btnConnectToRobot_Click);
            // 
            // lblRobotStatus
            // 
            this.lblRobotStatus.AutoSize = true;
            this.lblRobotStatus.Location = new System.Drawing.Point(295, 125);
            this.lblRobotStatus.Name = "lblRobotStatus";
            this.lblRobotStatus.Size = new System.Drawing.Size(201, 20);
            this.lblRobotStatus.TabIndex = 7;
            this.lblRobotStatus.Text = "NOT CONNECTED TO ROBOT";
            // 
            // lblConnectToCam
            // 
            this.lblConnectToCam.AutoSize = true;
            this.lblConnectToCam.Location = new System.Drawing.Point(295, 18);
            this.lblConnectToCam.Name = "lblConnectToCam";
            this.lblConnectToCam.Size = new System.Drawing.Size(213, 20);
            this.lblConnectToCam.TabIndex = 8;
            this.lblConnectToCam.Text = "NOT CONNECTED TO CAMERA";
            // 
            // lblConnectToLights
            // 
            this.lblConnectToLights.AutoSize = true;
            this.lblConnectToLights.Location = new System.Drawing.Point(295, 54);
            this.lblConnectToLights.Name = "lblConnectToLights";
            this.lblConnectToLights.Size = new System.Drawing.Size(202, 20);
            this.lblConnectToLights.TabIndex = 9;
            this.lblConnectToLights.Text = "NOT CONNECTED TO LIGHTS";
            // 
            // txbxLaserVal
            // 
            this.txbxLaserVal.Location = new System.Drawing.Point(514, 90);
            this.txbxLaserVal.Name = "txbxLaserVal";
            this.txbxLaserVal.Size = new System.Drawing.Size(151, 27);
            this.txbxLaserVal.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbxLaserVal);
            this.Controls.Add(this.lblConnectToLights);
            this.Controls.Add(this.lblConnectToCam);
            this.Controls.Add(this.lblRobotStatus);
            this.Controls.Add(this.btnConnectToRobot);
            this.Controls.Add(this.lblLaserVal);
            this.Controls.Add(this.btnConnectToLaser);
            this.Controls.Add(this.btnToggleLight);
            this.Controls.Add(this.cmbxCOMS);
            this.Controls.Add(this.btnConnectToFeather);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Slimhole Interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button btnStart;
        public Button btnConnectToFeather;
        public ComboBox cmbxCOMS;
        public Button btnToggleLight;
        public Button btnConnectToLaser;
        public Label lblLaserVal;
        public Button btnConnectToRobot;
        public Label lblRobotStatus;
        public Label lblConnectToCam;
        public Label lblConnectToLights;
        public TextBox txbxLaserVal;
    }
}