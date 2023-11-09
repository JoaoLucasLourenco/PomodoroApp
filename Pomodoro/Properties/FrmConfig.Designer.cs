namespace Pomodoro.Properties
{
    partial class FrmConfig
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLbreakInterval = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLbreakMin = new System.Windows.Forms.TextBox();
            this.txtBreakMin = new System.Windows.Forms.TextBox();
            this.txtPomoMin = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtLbreakInterval);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtLbreakMin);
            this.panel1.Controls.Add(this.txtBreakMin);
            this.panel1.Controls.Add(this.txtPomoMin);
            this.panel1.Location = new System.Drawing.Point(23, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 613);
            this.panel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MistyRose;
            this.label5.Location = new System.Drawing.Point(24, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Long Break Interval";
            // 
            // txtLbreakInterval
            // 
            this.txtLbreakInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLbreakInterval.Location = new System.Drawing.Point(218, 149);
            this.txtLbreakInterval.Name = "txtLbreakInterval";
            this.txtLbreakInterval.Size = new System.Drawing.Size(75, 30);
            this.txtLbreakInterval.TabIndex = 17;
            this.txtLbreakInterval.Text = "4";
            this.txtLbreakInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPomoMin_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MistyRose;
            this.label4.Location = new System.Drawing.Point(198, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Long Break";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MistyRose;
            this.label3.Location = new System.Drawing.Point(130, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Break";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MistyRose;
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pomodoro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Time (minutes)";
            // 
            // txtLbreakMin
            // 
            this.txtLbreakMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLbreakMin.Location = new System.Drawing.Point(218, 89);
            this.txtLbreakMin.Name = "txtLbreakMin";
            this.txtLbreakMin.Size = new System.Drawing.Size(75, 30);
            this.txtLbreakMin.TabIndex = 11;
            this.txtLbreakMin.Text = "15";
            this.txtLbreakMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPomoMin_KeyPress);
            // 
            // txtBreakMin
            // 
            this.txtBreakMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreakMin.Location = new System.Drawing.Point(123, 89);
            this.txtBreakMin.Name = "txtBreakMin";
            this.txtBreakMin.Size = new System.Drawing.Size(75, 30);
            this.txtBreakMin.TabIndex = 10;
            this.txtBreakMin.Text = "5";
            this.txtBreakMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPomoMin_KeyPress);
            // 
            // txtPomoMin
            // 
            this.txtPomoMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPomoMin.Location = new System.Drawing.Point(29, 89);
            this.txtPomoMin.Name = "txtPomoMin";
            this.txtPomoMin.Size = new System.Drawing.Size(75, 30);
            this.txtPomoMin.TabIndex = 8;
            this.txtPomoMin.Text = "25";
            this.txtPomoMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPomoMin_KeyPress);
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 720);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(365, 720);
            this.MinimumSize = new System.Drawing.Size(365, 720);
            this.Name = "FrmConfig";
            this.Text = "Config";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLbreakMin;
        private System.Windows.Forms.TextBox txtBreakMin;
        private System.Windows.Forms.TextBox txtPomoMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLbreakInterval;
    }
}