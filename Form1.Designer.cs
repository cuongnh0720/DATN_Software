
namespace MyAppDesign
{
    partial class MyAppDesign
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyAppDesign));
            this.lbTitle = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.pictureLogoKMA = new System.Windows.Forms.PictureBox();
            this.grpSerialPort = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.cboDataSize = new System.Windows.Forms.ComboBox();
            this.cboBaudrate = new System.Windows.Forms.ComboBox();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.ibParity = new System.Windows.Forms.Label();
            this.lbDataSize = new System.Windows.Forms.Label();
            this.lbBaudrate = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.grpCommand = new System.Windows.Forms.GroupBox();
            this.btnSendLED7Segment = new System.Windows.Forms.Button();
            this.btnSendDutyCycle = new System.Windows.Forms.Button();
            this.btnSendMaximumOuputPower = new System.Windows.Forms.Button();
            this.cboLED7Segment = new System.Windows.Forms.ComboBox();
            this.cboDutyCycle = new System.Windows.Forms.ComboBox();
            this.cboMaximumOutputPower = new System.Windows.Forms.ComboBox();
            this.btnSendRFOuput = new System.Windows.Forms.Button();
            this.txtRFOutput = new System.Windows.Forms.TextBox();
            this.lbLED7Segment = new System.Windows.Forms.Label();
            this.lbDutyCycle = new System.Windows.Forms.Label();
            this.lbMaximumOutputPower = new System.Windows.Forms.Label();
            this.lbRFOutput = new System.Windows.Forms.Label();
            this.grpMonitoring = new System.Windows.Forms.GroupBox();
            this.txtIntercept = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSlope = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.lbResponse = new System.Windows.Forms.Label();
            this.txtOutputPower = new System.Windows.Forms.TextBox();
            this.lbOutputPower = new System.Windows.Forms.Label();
            this.txtADCVoltage = new System.Windows.Forms.TextBox();
            this.lbADCVoltage = new System.Windows.Forms.Label();
            this.txtADCDeviation = new System.Windows.Forms.TextBox();
            this.lbADCDeviation = new System.Windows.Forms.Label();
            this.txtADCVoltageDistortion = new System.Windows.Forms.TextBox();
            this.lbADCVoltageDistortion = new System.Windows.Forms.Label();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.txtLoadVoltage = new System.Windows.Forms.TextBox();
            this.txtHumidity = new System.Windows.Forms.TextBox();
            this.lbPower = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.lbCurrent = new System.Windows.Forms.Label();
            this.lbLoadVoltage = new System.Windows.Forms.Label();
            this.lbHumidity = new System.Windows.Forms.Label();
            this.lbTemperature = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoKMA)).BeginInit();
            this.grpSerialPort.SuspendLayout();
            this.grpCommand.SuspendLayout();
            this.grpMonitoring.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(155, 75);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(667, 40);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "SYSTEM COMMAND AND MONITORING";
            // 
            // pictureLogoKMA
            // 
            this.pictureLogoKMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.pictureLogoKMA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureLogoKMA.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogoKMA.Image")));
            this.pictureLogoKMA.Location = new System.Drawing.Point(1051, 21);
            this.pictureLogoKMA.Name = "pictureLogoKMA";
            this.pictureLogoKMA.Size = new System.Drawing.Size(159, 149);
            this.pictureLogoKMA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogoKMA.TabIndex = 4;
            this.pictureLogoKMA.TabStop = false;
            // 
            // grpSerialPort
            // 
            this.grpSerialPort.Controls.Add(this.btnExit);
            this.grpSerialPort.Controls.Add(this.btnOpen);
            this.grpSerialPort.Controls.Add(this.cboParity);
            this.grpSerialPort.Controls.Add(this.cboDataSize);
            this.grpSerialPort.Controls.Add(this.cboBaudrate);
            this.grpSerialPort.Controls.Add(this.cboName);
            this.grpSerialPort.Controls.Add(this.ibParity);
            this.grpSerialPort.Controls.Add(this.lbDataSize);
            this.grpSerialPort.Controls.Add(this.lbBaudrate);
            this.grpSerialPort.Controls.Add(this.lbName);
            this.grpSerialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSerialPort.ForeColor = System.Drawing.Color.White;
            this.grpSerialPort.Location = new System.Drawing.Point(814, 179);
            this.grpSerialPort.Name = "grpSerialPort";
            this.grpSerialPort.Size = new System.Drawing.Size(427, 336);
            this.grpSerialPort.TabIndex = 5;
            this.grpSerialPort.TabStop = false;
            this.grpSerialPort.Text = "Serial interface";
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.btnExit.Location = new System.Drawing.Point(230, 261);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 43);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.btnOpen.Location = new System.Drawing.Point(35, 261);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(166, 43);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cboParity
            // 
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Location = new System.Drawing.Point(183, 210);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(213, 37);
            this.cboParity.TabIndex = 7;
            // 
            // cboDataSize
            // 
            this.cboDataSize.FormattingEnabled = true;
            this.cboDataSize.Location = new System.Drawing.Point(183, 159);
            this.cboDataSize.Name = "cboDataSize";
            this.cboDataSize.Size = new System.Drawing.Size(213, 37);
            this.cboDataSize.TabIndex = 6;
            // 
            // cboBaudrate
            // 
            this.cboBaudrate.FormattingEnabled = true;
            this.cboBaudrate.Location = new System.Drawing.Point(183, 108);
            this.cboBaudrate.Name = "cboBaudrate";
            this.cboBaudrate.Size = new System.Drawing.Size(213, 37);
            this.cboBaudrate.TabIndex = 5;
            // 
            // cboName
            // 
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(183, 57);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(213, 37);
            this.cboName.TabIndex = 4;
            // 
            // ibParity
            // 
            this.ibParity.AutoSize = true;
            this.ibParity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.ibParity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ibParity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibParity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibParity.ForeColor = System.Drawing.Color.White;
            this.ibParity.Location = new System.Drawing.Point(35, 210);
            this.ibParity.Name = "ibParity";
            this.ibParity.Size = new System.Drawing.Size(75, 31);
            this.ibParity.TabIndex = 3;
            this.ibParity.Text = "Parity";
            this.ibParity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDataSize
            // 
            this.lbDataSize.AutoSize = true;
            this.lbDataSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.lbDataSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDataSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDataSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataSize.ForeColor = System.Drawing.Color.White;
            this.lbDataSize.Location = new System.Drawing.Point(35, 159);
            this.lbDataSize.Name = "lbDataSize";
            this.lbDataSize.Size = new System.Drawing.Size(113, 31);
            this.lbDataSize.TabIndex = 2;
            this.lbDataSize.Text = "Data size";
            this.lbDataSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBaudrate
            // 
            this.lbBaudrate.AutoSize = true;
            this.lbBaudrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.lbBaudrate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbBaudrate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBaudrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBaudrate.ForeColor = System.Drawing.Color.White;
            this.lbBaudrate.Location = new System.Drawing.Point(35, 108);
            this.lbBaudrate.Name = "lbBaudrate";
            this.lbBaudrate.Size = new System.Drawing.Size(112, 31);
            this.lbBaudrate.TabIndex = 1;
            this.lbBaudrate.Text = "Baudrate";
            this.lbBaudrate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.lbName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(35, 57);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(80, 31);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpCommand
            // 
            this.grpCommand.Controls.Add(this.btnSendLED7Segment);
            this.grpCommand.Controls.Add(this.btnSendDutyCycle);
            this.grpCommand.Controls.Add(this.btnSendMaximumOuputPower);
            this.grpCommand.Controls.Add(this.cboLED7Segment);
            this.grpCommand.Controls.Add(this.cboDutyCycle);
            this.grpCommand.Controls.Add(this.cboMaximumOutputPower);
            this.grpCommand.Controls.Add(this.btnSendRFOuput);
            this.grpCommand.Controls.Add(this.txtRFOutput);
            this.grpCommand.Controls.Add(this.lbLED7Segment);
            this.grpCommand.Controls.Add(this.lbDutyCycle);
            this.grpCommand.Controls.Add(this.lbMaximumOutputPower);
            this.grpCommand.Controls.Add(this.lbRFOutput);
            this.grpCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCommand.ForeColor = System.Drawing.Color.White;
            this.grpCommand.Location = new System.Drawing.Point(15, 179);
            this.grpCommand.Name = "grpCommand";
            this.grpCommand.Size = new System.Drawing.Size(787, 335);
            this.grpCommand.TabIndex = 6;
            this.grpCommand.TabStop = false;
            this.grpCommand.Text = "Command";
            // 
            // btnSendLED7Segment
            // 
            this.btnSendLED7Segment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendLED7Segment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.btnSendLED7Segment.Location = new System.Drawing.Point(661, 267);
            this.btnSendLED7Segment.Name = "btnSendLED7Segment";
            this.btnSendLED7Segment.Size = new System.Drawing.Size(96, 37);
            this.btnSendLED7Segment.TabIndex = 11;
            this.btnSendLED7Segment.Text = "Send";
            this.btnSendLED7Segment.UseVisualStyleBackColor = true;
            this.btnSendLED7Segment.Click += new System.EventHandler(this.btnSendLED7Segment_Click);
            // 
            // btnSendDutyCycle
            // 
            this.btnSendDutyCycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendDutyCycle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.btnSendDutyCycle.Location = new System.Drawing.Point(661, 197);
            this.btnSendDutyCycle.Name = "btnSendDutyCycle";
            this.btnSendDutyCycle.Size = new System.Drawing.Size(96, 37);
            this.btnSendDutyCycle.TabIndex = 10;
            this.btnSendDutyCycle.Text = "Send";
            this.btnSendDutyCycle.UseVisualStyleBackColor = true;
            this.btnSendDutyCycle.Click += new System.EventHandler(this.btnSendDutyCycle_Click);
            // 
            // btnSendMaximumOuputPower
            // 
            this.btnSendMaximumOuputPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMaximumOuputPower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.btnSendMaximumOuputPower.Location = new System.Drawing.Point(661, 127);
            this.btnSendMaximumOuputPower.Name = "btnSendMaximumOuputPower";
            this.btnSendMaximumOuputPower.Size = new System.Drawing.Size(96, 37);
            this.btnSendMaximumOuputPower.TabIndex = 9;
            this.btnSendMaximumOuputPower.Text = "Send";
            this.btnSendMaximumOuputPower.UseVisualStyleBackColor = true;
            this.btnSendMaximumOuputPower.Click += new System.EventHandler(this.btnSendMaximumOuputPower_Click);
            // 
            // cboLED7Segment
            // 
            this.cboLED7Segment.FormattingEnabled = true;
            this.cboLED7Segment.Location = new System.Drawing.Point(418, 267);
            this.cboLED7Segment.Name = "cboLED7Segment";
            this.cboLED7Segment.Size = new System.Drawing.Size(213, 37);
            this.cboLED7Segment.TabIndex = 8;
            // 
            // cboDutyCycle
            // 
            this.cboDutyCycle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDutyCycle.FormattingEnabled = true;
            this.cboDutyCycle.Location = new System.Drawing.Point(418, 197);
            this.cboDutyCycle.Name = "cboDutyCycle";
            this.cboDutyCycle.Size = new System.Drawing.Size(213, 37);
            this.cboDutyCycle.TabIndex = 7;
            // 
            // cboMaximumOutputPower
            // 
            this.cboMaximumOutputPower.FormattingEnabled = true;
            this.cboMaximumOutputPower.Location = new System.Drawing.Point(418, 127);
            this.cboMaximumOutputPower.Name = "cboMaximumOutputPower";
            this.cboMaximumOutputPower.Size = new System.Drawing.Size(213, 37);
            this.cboMaximumOutputPower.TabIndex = 6;
            // 
            // btnSendRFOuput
            // 
            this.btnSendRFOuput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendRFOuput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.btnSendRFOuput.Location = new System.Drawing.Point(661, 57);
            this.btnSendRFOuput.Name = "btnSendRFOuput";
            this.btnSendRFOuput.Size = new System.Drawing.Size(96, 37);
            this.btnSendRFOuput.TabIndex = 5;
            this.btnSendRFOuput.Text = "Send";
            this.btnSendRFOuput.UseVisualStyleBackColor = true;
            this.btnSendRFOuput.Click += new System.EventHandler(this.btnSendRFOuput_Click);
            // 
            // txtRFOutput
            // 
            this.txtRFOutput.Location = new System.Drawing.Point(418, 57);
            this.txtRFOutput.Name = "txtRFOutput";
            this.txtRFOutput.Size = new System.Drawing.Size(213, 34);
            this.txtRFOutput.TabIndex = 4;
            // 
            // lbLED7Segment
            // 
            this.lbLED7Segment.AutoSize = true;
            this.lbLED7Segment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.lbLED7Segment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbLED7Segment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLED7Segment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLED7Segment.ForeColor = System.Drawing.Color.White;
            this.lbLED7Segment.Location = new System.Drawing.Point(35, 267);
            this.lbLED7Segment.Name = "lbLED7Segment";
            this.lbLED7Segment.Size = new System.Drawing.Size(179, 31);
            this.lbLED7Segment.TabIndex = 3;
            this.lbLED7Segment.Text = "LED 7 segment";
            this.lbLED7Segment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDutyCycle
            // 
            this.lbDutyCycle.AutoSize = true;
            this.lbDutyCycle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.lbDutyCycle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDutyCycle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDutyCycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDutyCycle.ForeColor = System.Drawing.Color.White;
            this.lbDutyCycle.Location = new System.Drawing.Point(35, 197);
            this.lbDutyCycle.Name = "lbDutyCycle";
            this.lbDutyCycle.Size = new System.Drawing.Size(167, 31);
            this.lbDutyCycle.TabIndex = 2;
            this.lbDutyCycle.Text = "Duty cycle (%)";
            this.lbDutyCycle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMaximumOutputPower
            // 
            this.lbMaximumOutputPower.AutoSize = true;
            this.lbMaximumOutputPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.lbMaximumOutputPower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMaximumOutputPower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbMaximumOutputPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaximumOutputPower.ForeColor = System.Drawing.Color.White;
            this.lbMaximumOutputPower.Location = new System.Drawing.Point(35, 127);
            this.lbMaximumOutputPower.Name = "lbMaximumOutputPower";
            this.lbMaximumOutputPower.Size = new System.Drawing.Size(336, 31);
            this.lbMaximumOutputPower.TabIndex = 1;
            this.lbMaximumOutputPower.Text = "Maximum output power (dBm)";
            this.lbMaximumOutputPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRFOutput
            // 
            this.lbRFOutput.AutoSize = true;
            this.lbRFOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.lbRFOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbRFOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbRFOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRFOutput.ForeColor = System.Drawing.Color.White;
            this.lbRFOutput.Location = new System.Drawing.Point(35, 57);
            this.lbRFOutput.Name = "lbRFOutput";
            this.lbRFOutput.Size = new System.Drawing.Size(189, 31);
            this.lbRFOutput.TabIndex = 0;
            this.lbRFOutput.Text = "RF output (MHz)";
            this.lbRFOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpMonitoring
            // 
            this.grpMonitoring.Controls.Add(this.txtIntercept);
            this.grpMonitoring.Controls.Add(this.label2);
            this.grpMonitoring.Controls.Add(this.txtSlope);
            this.grpMonitoring.Controls.Add(this.label1);
            this.grpMonitoring.Controls.Add(this.txtResponse);
            this.grpMonitoring.Controls.Add(this.lbResponse);
            this.grpMonitoring.Controls.Add(this.txtOutputPower);
            this.grpMonitoring.Controls.Add(this.lbOutputPower);
            this.grpMonitoring.Controls.Add(this.txtADCVoltage);
            this.grpMonitoring.Controls.Add(this.lbADCVoltage);
            this.grpMonitoring.Controls.Add(this.txtADCDeviation);
            this.grpMonitoring.Controls.Add(this.lbADCDeviation);
            this.grpMonitoring.Controls.Add(this.txtADCVoltageDistortion);
            this.grpMonitoring.Controls.Add(this.lbADCVoltageDistortion);
            this.grpMonitoring.Controls.Add(this.txtPower);
            this.grpMonitoring.Controls.Add(this.txtCurrent);
            this.grpMonitoring.Controls.Add(this.txtLoadVoltage);
            this.grpMonitoring.Controls.Add(this.txtHumidity);
            this.grpMonitoring.Controls.Add(this.lbPower);
            this.grpMonitoring.Controls.Add(this.txtTemperature);
            this.grpMonitoring.Controls.Add(this.lbCurrent);
            this.grpMonitoring.Controls.Add(this.lbLoadVoltage);
            this.grpMonitoring.Controls.Add(this.lbHumidity);
            this.grpMonitoring.Controls.Add(this.lbTemperature);
            this.grpMonitoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMonitoring.ForeColor = System.Drawing.Color.White;
            this.grpMonitoring.Location = new System.Drawing.Point(15, 514);
            this.grpMonitoring.Name = "grpMonitoring";
            this.grpMonitoring.Size = new System.Drawing.Size(1225, 380);
            this.grpMonitoring.TabIndex = 7;
            this.grpMonitoring.TabStop = false;
            this.grpMonitoring.Text = "Monitoring";
            // 
            // txtIntercept
            // 
            this.txtIntercept.Location = new System.Drawing.Point(1071, 248);
            this.txtIntercept.Name = "txtIntercept";
            this.txtIntercept.Size = new System.Drawing.Size(122, 34);
            this.txtIntercept.TabIndex = 23;
            this.txtIntercept.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(855, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 31);
            this.label2.TabIndex = 22;
            this.label2.Text = "Intercept (dBm)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSlope
            // 
            this.txtSlope.Location = new System.Drawing.Point(712, 248);
            this.txtSlope.Name = "txtSlope";
            this.txtSlope.Size = new System.Drawing.Size(122, 34);
            this.txtSlope.TabIndex = 21;
            this.txtSlope.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(500, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Slope (V/dB)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(358, 314);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(835, 34);
            this.txtResponse.TabIndex = 19;
            this.txtResponse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbResponse
            // 
            this.lbResponse.AutoSize = true;
            this.lbResponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.lbResponse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbResponse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResponse.ForeColor = System.Drawing.Color.White;
            this.lbResponse.Location = new System.Drawing.Point(35, 314);
            this.lbResponse.Name = "lbResponse";
            this.lbResponse.Size = new System.Drawing.Size(125, 31);
            this.lbResponse.TabIndex = 18;
            this.lbResponse.Text = "Response";
            this.lbResponse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOutputPower
            // 
            this.txtOutputPower.Location = new System.Drawing.Point(358, 248);
            this.txtOutputPower.Name = "txtOutputPower";
            this.txtOutputPower.Size = new System.Drawing.Size(122, 34);
            this.txtOutputPower.TabIndex = 17;
            this.txtOutputPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbOutputPower
            // 
            this.lbOutputPower.AutoSize = true;
            this.lbOutputPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.lbOutputPower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbOutputPower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbOutputPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutputPower.ForeColor = System.Drawing.Color.White;
            this.lbOutputPower.Location = new System.Drawing.Point(35, 248);
            this.lbOutputPower.Name = "lbOutputPower";
            this.lbOutputPower.Size = new System.Drawing.Size(232, 31);
            this.lbOutputPower.TabIndex = 16;
            this.lbOutputPower.Text = "Output power (dBm)";
            this.lbOutputPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtADCVoltage
            // 
            this.txtADCVoltage.Location = new System.Drawing.Point(1071, 182);
            this.txtADCVoltage.Name = "txtADCVoltage";
            this.txtADCVoltage.Size = new System.Drawing.Size(122, 34);
            this.txtADCVoltage.TabIndex = 15;
            this.txtADCVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbADCVoltage
            // 
            this.lbADCVoltage.AutoSize = true;
            this.lbADCVoltage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.lbADCVoltage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbADCVoltage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbADCVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbADCVoltage.ForeColor = System.Drawing.Color.White;
            this.lbADCVoltage.Location = new System.Drawing.Point(855, 182);
            this.lbADCVoltage.Name = "lbADCVoltage";
            this.lbADCVoltage.Size = new System.Drawing.Size(185, 31);
            this.lbADCVoltage.TabIndex = 14;
            this.lbADCVoltage.Text = "ADC voltage (V)";
            this.lbADCVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtADCDeviation
            // 
            this.txtADCDeviation.Location = new System.Drawing.Point(712, 182);
            this.txtADCDeviation.Name = "txtADCDeviation";
            this.txtADCDeviation.Size = new System.Drawing.Size(122, 34);
            this.txtADCDeviation.TabIndex = 13;
            this.txtADCDeviation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbADCDeviation
            // 
            this.lbADCDeviation.AutoSize = true;
            this.lbADCDeviation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.lbADCDeviation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbADCDeviation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbADCDeviation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbADCDeviation.ForeColor = System.Drawing.Color.White;
            this.lbADCDeviation.Location = new System.Drawing.Point(500, 182);
            this.lbADCDeviation.Name = "lbADCDeviation";
            this.lbADCDeviation.Size = new System.Drawing.Size(167, 31);
            this.lbADCDeviation.TabIndex = 12;
            this.lbADCDeviation.Text = "ADC deviation";
            this.lbADCDeviation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtADCVoltageDistortion
            // 
            this.txtADCVoltageDistortion.Location = new System.Drawing.Point(358, 182);
            this.txtADCVoltageDistortion.Name = "txtADCVoltageDistortion";
            this.txtADCVoltageDistortion.Size = new System.Drawing.Size(122, 34);
            this.txtADCVoltageDistortion.TabIndex = 11;
            this.txtADCVoltageDistortion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbADCVoltageDistortion
            // 
            this.lbADCVoltageDistortion.AutoSize = true;
            this.lbADCVoltageDistortion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.lbADCVoltageDistortion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbADCVoltageDistortion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbADCVoltageDistortion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbADCVoltageDistortion.ForeColor = System.Drawing.Color.White;
            this.lbADCVoltageDistortion.Location = new System.Drawing.Point(35, 182);
            this.lbADCVoltageDistortion.Name = "lbADCVoltageDistortion";
            this.lbADCVoltageDistortion.Size = new System.Drawing.Size(290, 31);
            this.lbADCVoltageDistortion.TabIndex = 10;
            this.lbADCVoltageDistortion.Text = "ADC voltage distortion (V)";
            this.lbADCVoltageDistortion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPower
            // 
            this.txtPower.Location = new System.Drawing.Point(1071, 119);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(122, 34);
            this.txtPower.TabIndex = 9;
            this.txtPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCurrent
            // 
            this.txtCurrent.Location = new System.Drawing.Point(712, 119);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(122, 34);
            this.txtCurrent.TabIndex = 8;
            this.txtCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLoadVoltage
            // 
            this.txtLoadVoltage.BackColor = System.Drawing.Color.White;
            this.txtLoadVoltage.Location = new System.Drawing.Point(358, 119);
            this.txtLoadVoltage.Name = "txtLoadVoltage";
            this.txtLoadVoltage.Size = new System.Drawing.Size(122, 34);
            this.txtLoadVoltage.TabIndex = 7;
            this.txtLoadVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHumidity
            // 
            this.txtHumidity.Location = new System.Drawing.Point(712, 57);
            this.txtHumidity.Name = "txtHumidity";
            this.txtHumidity.Size = new System.Drawing.Size(122, 34);
            this.txtHumidity.TabIndex = 6;
            this.txtHumidity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbPower
            // 
            this.lbPower.AutoSize = true;
            this.lbPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.lbPower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPower.ForeColor = System.Drawing.Color.White;
            this.lbPower.Location = new System.Drawing.Point(855, 119);
            this.lbPower.Name = "lbPower";
            this.lbPower.Size = new System.Drawing.Size(149, 31);
            this.lbPower.TabIndex = 5;
            this.lbPower.Text = "Power (mW)";
            this.lbPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(358, 57);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(122, 34);
            this.txtTemperature.TabIndex = 4;
            this.txtTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbCurrent
            // 
            this.lbCurrent.AutoSize = true;
            this.lbCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.lbCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCurrent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrent.ForeColor = System.Drawing.Color.White;
            this.lbCurrent.Location = new System.Drawing.Point(500, 119);
            this.lbCurrent.Name = "lbCurrent";
            this.lbCurrent.Size = new System.Drawing.Size(151, 31);
            this.lbCurrent.TabIndex = 3;
            this.lbCurrent.Text = "Current (mA)";
            this.lbCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLoadVoltage
            // 
            this.lbLoadVoltage.AutoSize = true;
            this.lbLoadVoltage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.lbLoadVoltage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbLoadVoltage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLoadVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoadVoltage.ForeColor = System.Drawing.Color.White;
            this.lbLoadVoltage.Location = new System.Drawing.Point(35, 119);
            this.lbLoadVoltage.Name = "lbLoadVoltage";
            this.lbLoadVoltage.Size = new System.Drawing.Size(190, 31);
            this.lbLoadVoltage.TabIndex = 2;
            this.lbLoadVoltage.Text = "Load voltage (V)";
            this.lbLoadVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHumidity
            // 
            this.lbHumidity.AutoSize = true;
            this.lbHumidity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.lbHumidity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbHumidity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHumidity.ForeColor = System.Drawing.Color.White;
            this.lbHumidity.Location = new System.Drawing.Point(500, 57);
            this.lbHumidity.Name = "lbHumidity";
            this.lbHumidity.Size = new System.Drawing.Size(186, 31);
            this.lbHumidity.TabIndex = 1;
            this.lbHumidity.Text = "Humidity (%RH)";
            this.lbHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTemperature
            // 
            this.lbTemperature.AutoSize = true;
            this.lbTemperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.lbTemperature.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTemperature.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemperature.ForeColor = System.Drawing.Color.White;
            this.lbTemperature.Location = new System.Drawing.Point(35, 57);
            this.lbTemperature.Name = "lbTemperature";
            this.lbTemperature.Size = new System.Drawing.Size(202, 31);
            this.lbTemperature.TabIndex = 0;
            this.lbTemperature.Text = "Temperature (°C)";
            this.lbTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyAppDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1252, 904);
            this.Controls.Add(this.grpMonitoring);
            this.Controls.Add(this.grpCommand);
            this.Controls.Add(this.grpSerialPort);
            this.Controls.Add(this.pictureLogoKMA);
            this.Controls.Add(this.lbTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MyAppDesign";
            this.Text = "My App Design";
            this.Load += new System.EventHandler(this.MyAppDesign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoKMA)).EndInit();
            this.grpSerialPort.ResumeLayout(false);
            this.grpSerialPort.PerformLayout();
            this.grpCommand.ResumeLayout(false);
            this.grpCommand.PerformLayout();
            this.grpMonitoring.ResumeLayout(false);
            this.grpMonitoring.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitle;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.PictureBox pictureLogoKMA;
        private System.Windows.Forms.GroupBox grpSerialPort;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbBaudrate;
        private System.Windows.Forms.Label ibParity;
        private System.Windows.Forms.Label lbDataSize;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.ComboBox cboDataSize;
        private System.Windows.Forms.ComboBox cboBaudrate;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.GroupBox grpCommand;
        private System.Windows.Forms.Label lbLED7Segment;
        private System.Windows.Forms.Label lbDutyCycle;
        private System.Windows.Forms.Label lbMaximumOutputPower;
        private System.Windows.Forms.Label lbRFOutput;
        private System.Windows.Forms.TextBox txtRFOutput;
        private System.Windows.Forms.Button btnSendLED7Segment;
        private System.Windows.Forms.Button btnSendDutyCycle;
        private System.Windows.Forms.Button btnSendMaximumOuputPower;
        private System.Windows.Forms.ComboBox cboLED7Segment;
        private System.Windows.Forms.ComboBox cboDutyCycle;
        private System.Windows.Forms.ComboBox cboMaximumOutputPower;
        private System.Windows.Forms.Button btnSendRFOuput;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox grpMonitoring;
        private System.Windows.Forms.Label lbCurrent;
        private System.Windows.Forms.Label lbLoadVoltage;
        private System.Windows.Forms.Label lbHumidity;
        private System.Windows.Forms.Label lbTemperature;
        private System.Windows.Forms.Label lbPower;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.TextBox txtLoadVoltage;
        private System.Windows.Forms.TextBox txtHumidity;
        private System.Windows.Forms.TextBox txtOutputPower;
        private System.Windows.Forms.Label lbOutputPower;
        private System.Windows.Forms.TextBox txtADCVoltage;
        private System.Windows.Forms.Label lbADCVoltage;
        private System.Windows.Forms.TextBox txtADCDeviation;
        private System.Windows.Forms.Label lbADCDeviation;
        private System.Windows.Forms.TextBox txtADCVoltageDistortion;
        private System.Windows.Forms.Label lbADCVoltageDistortion;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label lbResponse;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtIntercept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSlope;
        private System.Windows.Forms.Label label1;
    }
}

