namespace doitcar
{
    partial class Form1
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblConnState = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnASpeedUp = new System.Windows.Forms.Button();
            this.btnASpeedDown = new System.Windows.Forms.Button();
            this.btnBspeedUp = new System.Windows.Forms.Button();
            this.btnBSpeedDown = new System.Windows.Forms.Button();
            this.txtbRoute = new System.Windows.Forms.TextBox();
            this.btnGO = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.chkRoute = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 35);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(82, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblConnState
            // 
            this.lblConnState.AutoSize = true;
            this.lblConnState.Location = new System.Drawing.Point(13, 19);
            this.lblConnState.Name = "lblConnState";
            this.lblConnState.Size = new System.Drawing.Size(81, 13);
            this.lblConnState.TabIndex = 1;
            this.lblConnState.Text = "Not connected.";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(12, 84);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(150, 20);
            this.txtIP.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(12, 132);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(150, 20);
            this.txtPort.TabIndex = 7;
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(61, 165);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(52, 36);
            this.btnForward.TabIndex = 11;
            this.btnForward.Text = "^";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.Location = new System.Drawing.Point(61, 249);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(52, 36);
            this.btnBackward.TabIndex = 12;
            this.btnBackward.Text = "ˇ";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(12, 207);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(43, 36);
            this.btnLeft.TabIndex = 13;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(119, 207);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(43, 36);
            this.btnRight.TabIndex = 14;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(61, 207);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(52, 36);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnASpeedUp
            // 
            this.btnASpeedUp.Location = new System.Drawing.Point(12, 165);
            this.btnASpeedUp.Name = "btnASpeedUp";
            this.btnASpeedUp.Size = new System.Drawing.Size(43, 36);
            this.btnASpeedUp.TabIndex = 16;
            this.btnASpeedUp.Text = "<<";
            this.btnASpeedUp.UseVisualStyleBackColor = true;
            this.btnASpeedUp.Click += new System.EventHandler(this.btnASpeedUp_Click);
            // 
            // btnASpeedDown
            // 
            this.btnASpeedDown.Location = new System.Drawing.Point(12, 249);
            this.btnASpeedDown.Name = "btnASpeedDown";
            this.btnASpeedDown.Size = new System.Drawing.Size(43, 36);
            this.btnASpeedDown.TabIndex = 17;
            this.btnASpeedDown.Text = ">>";
            this.btnASpeedDown.UseVisualStyleBackColor = true;
            this.btnASpeedDown.Click += new System.EventHandler(this.btnASpeedDown_Click);
            // 
            // btnBspeedUp
            // 
            this.btnBspeedUp.Location = new System.Drawing.Point(119, 165);
            this.btnBspeedUp.Name = "btnBspeedUp";
            this.btnBspeedUp.Size = new System.Drawing.Size(43, 36);
            this.btnBspeedUp.TabIndex = 18;
            this.btnBspeedUp.Text = ">>";
            this.btnBspeedUp.UseVisualStyleBackColor = true;
            this.btnBspeedUp.Click += new System.EventHandler(this.btnBspeedUp_Click);
            // 
            // btnBSpeedDown
            // 
            this.btnBSpeedDown.Location = new System.Drawing.Point(119, 249);
            this.btnBSpeedDown.Name = "btnBSpeedDown";
            this.btnBSpeedDown.Size = new System.Drawing.Size(43, 36);
            this.btnBSpeedDown.TabIndex = 19;
            this.btnBSpeedDown.Text = "<<";
            this.btnBSpeedDown.UseVisualStyleBackColor = true;
            this.btnBSpeedDown.Click += new System.EventHandler(this.btnBSpeedDown_Click);
            // 
            // txtbRoute
            // 
            this.txtbRoute.Location = new System.Drawing.Point(185, 48);
            this.txtbRoute.Multiline = true;
            this.txtbRoute.Name = "txtbRoute";
            this.txtbRoute.ReadOnly = true;
            this.txtbRoute.Size = new System.Drawing.Size(125, 237);
            this.txtbRoute.TabIndex = 21;
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(185, 291);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(125, 23);
            this.btnGO.TabIndex = 22;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(12, 291);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(150, 23);
            this.btnDisconnect.TabIndex = 23;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // chkRoute
            // 
            this.chkRoute.AutoSize = true;
            this.chkRoute.Location = new System.Drawing.Point(185, 19);
            this.chkRoute.Name = "chkRoute";
            this.chkRoute.Size = new System.Drawing.Size(84, 17);
            this.chkRoute.TabIndex = 24;
            this.chkRoute.Text = "Define route";
            this.chkRoute.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 322);
            this.Controls.Add(this.chkRoute);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.txtbRoute);
            this.Controls.Add(this.btnBSpeedDown);
            this.Controls.Add(this.btnBspeedUp);
            this.Controls.Add(this.btnASpeedDown);
            this.Controls.Add(this.btnASpeedUp);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lblConnState);
            this.Controls.Add(this.btnConnect);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblConnState;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnASpeedUp;
        private System.Windows.Forms.Button btnASpeedDown;
        private System.Windows.Forms.Button btnBspeedUp;
        private System.Windows.Forms.Button btnBSpeedDown;
        private System.Windows.Forms.TextBox txtbRoute;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.CheckBox chkRoute;
    }
}

