namespace ShutDown_Timer
{
    partial class Timer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timer));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHour = new System.Windows.Forms.TextBox();
            this.activatebtn = new System.Windows.Forms.Button();
            this.deactivatebtn = new System.Windows.Forms.Button();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxSec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // textBoxHour
            // 
            this.textBoxHour.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.textBoxHour, "textBoxHour");
            this.textBoxHour.Name = "textBoxHour";
            // 
            // activatebtn
            // 
            resources.ApplyResources(this.activatebtn, "activatebtn");
            this.activatebtn.Name = "activatebtn";
            this.activatebtn.UseVisualStyleBackColor = true;
            this.activatebtn.Click += new System.EventHandler(this.activatebtn_Click);
            // 
            // deactivatebtn
            // 
            resources.ApplyResources(this.deactivatebtn, "deactivatebtn");
            this.deactivatebtn.Name = "deactivatebtn";
            this.deactivatebtn.UseVisualStyleBackColor = true;
            this.deactivatebtn.Click += new System.EventHandler(this.deactivatebtn_Click);
            // 
            // textBoxMin
            // 
            this.textBoxMin.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.textBoxMin, "textBoxMin");
            this.textBoxMin.Name = "textBoxMin";
            // 
            // textBoxSec
            // 
            this.textBoxSec.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.textBoxSec, "textBoxSec");
            this.textBoxSec.Name = "textBoxSec";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Name = "label3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.deactivatebtn);
            this.panel1.Controls.Add(this.activatebtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxHour);
            this.panel1.Controls.Add(this.textBoxSec);
            this.panel1.Controls.Add(this.textBoxMin);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Name = "label4";
            // 
            // Timer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Timer";
            this.ShowIcon = false;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHour;
        private System.Windows.Forms.Button activatebtn;
        private System.Windows.Forms.Button deactivatebtn;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}

