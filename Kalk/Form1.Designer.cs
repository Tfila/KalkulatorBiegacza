namespace Kalk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.output = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonTimeOfLap = new System.Windows.Forms.RadioButton();
            this.radioButtonTotalTime = new System.Windows.Forms.RadioButton();
            this.numberOfLaps = new System.Windows.Forms.TextBox();
            this.lengthOfLap = new System.Windows.Forms.TextBox();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.outputT2 = new System.Windows.Forms.RichTextBox();
            this.calculateT2 = new System.Windows.Forms.Button();
            this.numberOfLapsT2 = new System.Windows.Forms.TextBox();
            this.lengthOfLapT2 = new System.Windows.Forms.TextBox();
            this.prefferedTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.calculateT3 = new System.Windows.Forms.Button();
            this.resultT3 = new System.Windows.Forms.RichTextBox();
            this.numberOfLapsT3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lapLengthT3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.prefferedSpeed = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(460, 495);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(452, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sprawdź swoje wyniki";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.output);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButtonTimeOfLap);
            this.panel1.Controls.Add(this.radioButtonTotalTime);
            this.panel1.Controls.Add(this.numberOfLaps);
            this.panel1.Controls.Add(this.lengthOfLap);
            this.panel1.Controls.Add(this.timeBox);
            this.panel1.Controls.Add(this.calculate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 469);
            this.panel1.TabIndex = 0;
            // 
            // output
            // 
            this.output.AcceptsTab = true;
            this.output.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.output.BulletIndent = 5;
            this.output.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.output.Location = new System.Drawing.Point(60, 235);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(300, 205);
            this.output.TabIndex = 11;
            this.output.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Czas okrążenia [mm:ss] :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Czas całkowity [mm:ss] :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ilość okrążeń :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Długość okrążenia [m] :";
            // 
            // radioButtonTimeOfLap
            // 
            this.radioButtonTimeOfLap.AutoSize = true;
            this.radioButtonTimeOfLap.Location = new System.Drawing.Point(210, 165);
            this.radioButtonTimeOfLap.Name = "radioButtonTimeOfLap";
            this.radioButtonTimeOfLap.Size = new System.Drawing.Size(14, 13);
            this.radioButtonTimeOfLap.TabIndex = 4;
            this.radioButtonTimeOfLap.TabStop = true;
            this.radioButtonTimeOfLap.UseVisualStyleBackColor = true;
            this.radioButtonTimeOfLap.CheckedChanged += new System.EventHandler(this.radioButtonTimeOfLap_CheckedChanged);
            // 
            // radioButtonTotalTime
            // 
            this.radioButtonTotalTime.AutoSize = true;
            this.radioButtonTotalTime.Checked = true;
            this.radioButtonTotalTime.Location = new System.Drawing.Point(210, 140);
            this.radioButtonTotalTime.Name = "radioButtonTotalTime";
            this.radioButtonTotalTime.Size = new System.Drawing.Size(14, 13);
            this.radioButtonTotalTime.TabIndex = 3;
            this.radioButtonTotalTime.TabStop = true;
            this.radioButtonTotalTime.UseVisualStyleBackColor = true;
            this.radioButtonTotalTime.CheckedChanged += new System.EventHandler(this.radioButtonTotalTime_CheckedChanged);
            // 
            // numberOfLaps
            // 
            this.numberOfLaps.Location = new System.Drawing.Point(290, 100);
            this.numberOfLaps.Name = "numberOfLaps";
            this.numberOfLaps.Size = new System.Drawing.Size(65, 20);
            this.numberOfLaps.TabIndex = 2;
            this.numberOfLaps.Text = "1";
            // 
            // lengthOfLap
            // 
            this.lengthOfLap.Location = new System.Drawing.Point(290, 60);
            this.lengthOfLap.Name = "lengthOfLap";
            this.lengthOfLap.Size = new System.Drawing.Size(65, 20);
            this.lengthOfLap.TabIndex = 1;
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(290, 140);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(65, 20);
            this.timeBox.TabIndex = 5;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(265, 190);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(111, 35);
            this.calculate.TabIndex = 6;
            this.calculate.Text = "Oblicz";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(452, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Preferowany czas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.outputT2);
            this.panel2.Controls.Add(this.calculateT2);
            this.panel2.Controls.Add(this.numberOfLapsT2);
            this.panel2.Controls.Add(this.lengthOfLapT2);
            this.panel2.Controls.Add(this.prefferedTime);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 467);
            this.panel2.TabIndex = 0;
            // 
            // outputT2
            // 
            this.outputT2.AcceptsTab = true;
            this.outputT2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.outputT2.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outputT2.Location = new System.Drawing.Point(60, 235);
            this.outputT2.Name = "outputT2";
            this.outputT2.ReadOnly = true;
            this.outputT2.Size = new System.Drawing.Size(300, 205);
            this.outputT2.TabIndex = 7;
            this.outputT2.Text = "";
            // 
            // calculateT2
            // 
            this.calculateT2.Location = new System.Drawing.Point(265, 190);
            this.calculateT2.Name = "calculateT2";
            this.calculateT2.Size = new System.Drawing.Size(111, 35);
            this.calculateT2.TabIndex = 6;
            this.calculateT2.Text = "Oblicz";
            this.calculateT2.UseVisualStyleBackColor = true;
            this.calculateT2.Click += new System.EventHandler(this.calculateT2_Click);
            // 
            // numberOfLapsT2
            // 
            this.numberOfLapsT2.Location = new System.Drawing.Point(290, 140);
            this.numberOfLapsT2.Name = "numberOfLapsT2";
            this.numberOfLapsT2.Size = new System.Drawing.Size(65, 20);
            this.numberOfLapsT2.TabIndex = 5;
            this.numberOfLapsT2.Text = "1";
            // 
            // lengthOfLapT2
            // 
            this.lengthOfLapT2.Location = new System.Drawing.Point(290, 100);
            this.lengthOfLapT2.Name = "lengthOfLapT2";
            this.lengthOfLapT2.Size = new System.Drawing.Size(65, 20);
            this.lengthOfLapT2.TabIndex = 4;
            // 
            // prefferedTime
            // 
            this.prefferedTime.Location = new System.Drawing.Point(290, 60);
            this.prefferedTime.Name = "prefferedTime";
            this.prefferedTime.Size = new System.Drawing.Size(65, 20);
            this.prefferedTime.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ilość okrążeń :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Długość okrążenia [m] :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Preferowany czas na 1 km [mm:ss] :";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(452, 467);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Preferowana prędkość";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.calculateT3);
            this.panel3.Controls.Add(this.resultT3);
            this.panel3.Controls.Add(this.numberOfLapsT3);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.lapLengthT3);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.prefferedSpeed);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(452, 467);
            this.panel3.TabIndex = 0;
            // 
            // calculateT3
            // 
            this.calculateT3.Location = new System.Drawing.Point(265, 190);
            this.calculateT3.Name = "calculateT3";
            this.calculateT3.Size = new System.Drawing.Size(111, 35);
            this.calculateT3.TabIndex = 3;
            this.calculateT3.Text = "Oblicz";
            this.calculateT3.UseVisualStyleBackColor = true;
            this.calculateT3.Click += new System.EventHandler(this.calculateT3_Click);
            // 
            // resultT3
            // 
            this.resultT3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.resultT3.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultT3.Location = new System.Drawing.Point(60, 235);
            this.resultT3.Name = "resultT3";
            this.resultT3.ReadOnly = true;
            this.resultT3.Size = new System.Drawing.Size(300, 205);
            this.resultT3.TabIndex = 6;
            this.resultT3.Text = "";
            // 
            // numberOfLapsT3
            // 
            this.numberOfLapsT3.Location = new System.Drawing.Point(290, 140);
            this.numberOfLapsT3.Name = "numberOfLapsT3";
            this.numberOfLapsT3.Size = new System.Drawing.Size(65, 20);
            this.numberOfLapsT3.TabIndex = 2;
            this.numberOfLapsT3.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Ilość okrążeń :";
            // 
            // lapLengthT3
            // 
            this.lapLengthT3.Location = new System.Drawing.Point(290, 100);
            this.lapLengthT3.Name = "lapLengthT3";
            this.lapLengthT3.Size = new System.Drawing.Size(65, 20);
            this.lapLengthT3.TabIndex = 1;
            this.lapLengthT3.Text = "1000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Długość okrążenia [m] :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Preferowana prędkość [km/h] :";
            // 
            // prefferedSpeed
            // 
            this.prefferedSpeed.Location = new System.Drawing.Point(290, 60);
            this.prefferedSpeed.Name = "prefferedSpeed";
            this.prefferedSpeed.Size = new System.Drawing.Size(65, 20);
            this.prefferedSpeed.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(460, 495);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kalkulator biegacza";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox numberOfLaps;
        private System.Windows.Forms.TextBox lengthOfLap;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.RadioButton radioButtonTimeOfLap;
        private System.Windows.Forms.RadioButton radioButtonTotalTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numberOfLapsT2;
        private System.Windows.Forms.TextBox lengthOfLapT2;
        private System.Windows.Forms.TextBox prefferedTime;
        private System.Windows.Forms.Button calculateT2;
        private System.Windows.Forms.RichTextBox outputT2;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox prefferedSpeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lapLengthT3;
        private System.Windows.Forms.TextBox numberOfLapsT3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox resultT3;
        private System.Windows.Forms.Button calculateT3;
    }
}