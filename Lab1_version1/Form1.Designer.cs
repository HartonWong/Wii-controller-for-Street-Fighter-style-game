namespace Lab1_version1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxAx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAz = new System.Windows.Forms.TextBox();
            this.checkBoxSaveToFile = new System.Windows.Forms.CheckBox();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonFileName = new System.Windows.Forms.Button();
            this.textBoxCurrentGestureState = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxOrientation = new System.Windows.Forms.TextBox();
            this.textBoxXAvg = new System.Windows.Forms.TextBox();
            this.textBoxYAvg = new System.Windows.Forms.TextBox();
            this.textBoxZAvg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDragon = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDevil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDragon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDevil)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(12, 12);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxComPort.TabIndex = 0;
            this.comboBoxComPort.DropDown += new System.EventHandler(this.comboBoxComPort_DropDown);
            this.comboBoxComPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxComPort_SelectedIndexChanged);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(156, 10);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAx
            // 
            this.textBoxAx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxAx.Location = new System.Drawing.Point(12, 39);
            this.textBoxAx.Name = "textBoxAx";
            this.textBoxAx.Size = new System.Drawing.Size(121, 26);
            this.textBoxAx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(139, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "X-Axis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(329, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y-Axis";
            // 
            // textBoxAy
            // 
            this.textBoxAy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxAy.Location = new System.Drawing.Point(202, 36);
            this.textBoxAy.Name = "textBoxAy";
            this.textBoxAy.Size = new System.Drawing.Size(121, 26);
            this.textBoxAy.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(519, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Z-Axis";
            // 
            // textBoxAz
            // 
            this.textBoxAz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxAz.Location = new System.Drawing.Point(392, 36);
            this.textBoxAz.Name = "textBoxAz";
            this.textBoxAz.Size = new System.Drawing.Size(121, 26);
            this.textBoxAz.TabIndex = 6;
            // 
            // checkBoxSaveToFile
            // 
            this.checkBoxSaveToFile.AutoSize = true;
            this.checkBoxSaveToFile.Location = new System.Drawing.Point(587, 8);
            this.checkBoxSaveToFile.Name = "checkBoxSaveToFile";
            this.checkBoxSaveToFile.Size = new System.Drawing.Size(86, 17);
            this.checkBoxSaveToFile.TabIndex = 8;
            this.checkBoxSaveToFile.Text = "Save To File";
            this.checkBoxSaveToFile.UseVisualStyleBackColor = true;
            this.checkBoxSaveToFile.CheckedChanged += new System.EventHandler(this.checkBoxSaveToFile_CheckedChanged);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(584, 30);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFileName.TabIndex = 9;
            // 
            // buttonFileName
            // 
            this.buttonFileName.Location = new System.Drawing.Point(692, 9);
            this.buttonFileName.Name = "buttonFileName";
            this.buttonFileName.Size = new System.Drawing.Size(75, 44);
            this.buttonFileName.TabIndex = 10;
            this.buttonFileName.Text = "Select Directory";
            this.buttonFileName.UseVisualStyleBackColor = true;
            this.buttonFileName.Click += new System.EventHandler(this.buttonFileName_Click);
            // 
            // textBoxCurrentGestureState
            // 
            this.textBoxCurrentGestureState.Location = new System.Drawing.Point(1028, 4);
            this.textBoxCurrentGestureState.Name = "textBoxCurrentGestureState";
            this.textBoxCurrentGestureState.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrentGestureState.TabIndex = 11;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxCount.Location = new System.Drawing.Point(261, 3);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(121, 26);
            this.textBoxCount.TabIndex = 13;
            // 
            // textBoxOrientation
            // 
            this.textBoxOrientation.Location = new System.Drawing.Point(803, 4);
            this.textBoxOrientation.Name = "textBoxOrientation";
            this.textBoxOrientation.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrientation.TabIndex = 14;
            // 
            // textBoxXAvg
            // 
            this.textBoxXAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxXAvg.Location = new System.Drawing.Point(13, 73);
            this.textBoxXAvg.Name = "textBoxXAvg";
            this.textBoxXAvg.Size = new System.Drawing.Size(121, 26);
            this.textBoxXAvg.TabIndex = 15;
            // 
            // textBoxYAvg
            // 
            this.textBoxYAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxYAvg.Location = new System.Drawing.Point(202, 73);
            this.textBoxYAvg.Name = "textBoxYAvg";
            this.textBoxYAvg.Size = new System.Drawing.Size(121, 26);
            this.textBoxYAvg.TabIndex = 16;
            // 
            // textBoxZAvg
            // 
            this.textBoxZAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxZAvg.Location = new System.Drawing.Point(392, 73);
            this.textBoxZAvg.Name = "textBoxZAvg";
            this.textBoxZAvg.Size = new System.Drawing.Size(121, 26);
            this.textBoxZAvg.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(140, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "X-Avg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(328, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Y-Avg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(519, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Z-Avg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(1133, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Gesture State";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(908, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Orientation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(388, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Display Wait Time";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(556, 298);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 112);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(864, 360);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 62);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxDragon
            // 
            this.pictureBoxDragon.Image = global::Lab1_version1.Properties.Resources.Dragon;
            this.pictureBoxDragon.Location = new System.Drawing.Point(755, 12);
            this.pictureBoxDragon.Name = "pictureBoxDragon";
            this.pictureBoxDragon.Size = new System.Drawing.Size(213, 213);
            this.pictureBoxDragon.TabIndex = 30;
            this.pictureBoxDragon.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(308, 349);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(130, 61);
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBoxDevil
            // 
            this.pictureBoxDevil.Image = global::Lab1_version1.Properties.Resources.devils020;
            this.pictureBoxDevil.Location = new System.Drawing.Point(308, 100);
            this.pictureBoxDevil.Name = "pictureBoxDevil";
            this.pictureBoxDevil.Size = new System.Drawing.Size(157, 149);
            this.pictureBoxDevil.TabIndex = 32;
            this.pictureBoxDevil.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1255, 487);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxDevil);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBoxDragon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxZAvg);
            this.Controls.Add(this.textBoxYAvg);
            this.Controls.Add(this.textBoxXAvg);
            this.Controls.Add(this.textBoxOrientation);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.textBoxCurrentGestureState);
            this.Controls.Add(this.buttonFileName);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.checkBoxSaveToFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAx);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBoxComPort);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Stickman Shooting Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDragon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDevil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxAx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAz;
        private System.Windows.Forms.CheckBox checkBoxSaveToFile;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonFileName;
        private System.Windows.Forms.TextBox textBoxCurrentGestureState;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxOrientation;
        private System.Windows.Forms.TextBox textBoxXAvg;
        private System.Windows.Forms.TextBox textBoxYAvg;
        private System.Windows.Forms.TextBox textBoxZAvg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxDragon;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBoxDevil;
    }
}

