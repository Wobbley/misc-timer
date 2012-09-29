namespace Timed_Shutdown
{
    partial class Window_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window_Main));
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerHours = new System.Windows.Forms.NumericUpDown();
            this.timerSeconds = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerMinutes = new System.Windows.Forms.NumericUpDown();
            this.labelHours = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.comboTask = new System.Windows.Forms.ComboBox();
            this.checkBoxForced = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.timerHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerSeconds)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerMinutes)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(61, 129);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 25);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerHours
            // 
            this.timerHours.Location = new System.Drawing.Point(15, 3);
            this.timerHours.Name = "timerHours";
            this.timerHours.Size = new System.Drawing.Size(41, 20);
            this.timerHours.TabIndex = 6;
            // 
            // timerSeconds
            // 
            this.timerSeconds.Location = new System.Drawing.Point(129, 3);
            this.timerSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.timerSeconds.Name = "timerSeconds";
            this.timerSeconds.Size = new System.Drawing.Size(41, 20);
            this.timerSeconds.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.timerSeconds);
            this.panel1.Controls.Add(this.timerHours);
            this.panel1.Controls.Add(this.timerMinutes);
            this.panel1.Location = new System.Drawing.Point(7, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 46);
            this.panel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seconds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Minutes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hours";
            // 
            // timerMinutes
            // 
            this.timerMinutes.Location = new System.Drawing.Point(71, 3);
            this.timerMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.timerMinutes.Name = "timerMinutes";
            this.timerMinutes.Size = new System.Drawing.Size(41, 20);
            this.timerMinutes.TabIndex = 5;
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHours.Location = new System.Drawing.Point(32, 108);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(26, 18);
            this.labelHours.TabIndex = 8;
            this.labelHours.Text = "00";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(61, 129);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 25);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeconds.Location = new System.Drawing.Point(151, 108);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(26, 18);
            this.labelSeconds.TabIndex = 4;
            this.labelSeconds.Text = "00";
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinutes.Location = new System.Drawing.Point(93, 108);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(26, 18);
            this.labelMinutes.TabIndex = 7;
            this.labelMinutes.Text = "00";
            // 
            // comboTask
            // 
            this.comboTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTask.FormattingEnabled = true;
            this.comboTask.Items.AddRange(new object[] {
            "Log Off",
            "Shutdown",
            "Reboot",
            "Alarm"});
            this.comboTask.Location = new System.Drawing.Point(71, 11);
            this.comboTask.Name = "comboTask";
            this.comboTask.Size = new System.Drawing.Size(115, 21);
            this.comboTask.TabIndex = 9;
            // 
            // checkBoxForced
            // 
            this.checkBoxForced.AutoSize = true;
            this.checkBoxForced.Location = new System.Drawing.Point(5, 14);
            this.checkBoxForced.Name = "checkBoxForced";
            this.checkBoxForced.Size = new System.Drawing.Size(60, 18);
            this.checkBoxForced.TabIndex = 10;
            this.checkBoxForced.Text = "Forced";
            this.checkBoxForced.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBoxForced);
            this.panel2.Controls.Add(this.comboTask);
            this.panel2.Location = new System.Drawing.Point(7, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 50);
            this.panel2.TabIndex = 13;
            // 
            // Window_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 161);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.labelMinutes);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Window_Main";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Misc. Timer";
            ((System.ComponentModel.ISupportInitialize)(this.timerHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerSeconds)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerMinutes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown timerHours;
        private System.Windows.Forms.NumericUpDown timerSeconds;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown timerMinutes;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.ComboBox comboTask;
        private System.Windows.Forms.CheckBox checkBoxForced;
        private System.Windows.Forms.Panel panel2;
    }
}

