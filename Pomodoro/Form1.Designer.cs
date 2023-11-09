namespace Pomodoro
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfig = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.restBtn = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.startBtn = new MetroFramework.Controls.MetroButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.btnConfig);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.metroButton4);
            this.panel1.Controls.Add(this.restBtn);
            this.panel1.Controls.Add(this.metroButton2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Location = new System.Drawing.Point(23, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 613);
            this.panel1.TabIndex = 6;
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfig.BackColor = System.Drawing.Color.IndianRed;
            this.btnConfig.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnConfig.Location = new System.Drawing.Point(194, 534);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(109, 62);
            this.btnConfig.TabIndex = 11;
            this.btnConfig.Text = "Config";
            this.btnConfig.UseSelectable = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MistyRose;
            this.label2.Location = new System.Drawing.Point(147, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "#0";
            // 
            // metroButton4
            // 
            this.metroButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton4.BackColor = System.Drawing.Color.IndianRed;
            this.metroButton4.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton4.ForeColor = System.Drawing.Color.MistyRose;
            this.metroButton4.Location = new System.Drawing.Point(52, 179);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(211, 38);
            this.metroButton4.TabIndex = 10;
            this.metroButton4.Text = "LONG BREAK";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // restBtn
            // 
            this.restBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.restBtn.BackColor = System.Drawing.Color.IndianRed;
            this.restBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.restBtn.Location = new System.Drawing.Point(179, 223);
            this.restBtn.Name = "restBtn";
            this.restBtn.Size = new System.Drawing.Size(84, 38);
            this.restBtn.TabIndex = 9;
            this.restBtn.Text = "BREAK";
            this.restBtn.UseSelectable = true;
            this.restBtn.Click += new System.EventHandler(this.restBtn_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton2.BackColor = System.Drawing.Color.IndianRed;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton2.Location = new System.Drawing.Point(52, 223);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(84, 38);
            this.metroButton2.TabIndex = 8;
            this.metroButton2.Text = "FOCUS";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(36, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 95);
            this.label1.TabIndex = 7;
            this.label1.Text = "25:00";
            // 
            // startBtn
            // 
            this.startBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startBtn.BackColor = System.Drawing.Color.IndianRed;
            this.startBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.startBtn.Location = new System.Drawing.Point(52, 389);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(211, 38);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "START";
            this.startBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.startBtn.UseSelectable = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 720);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(365, 720);
            this.MinimumSize = new System.Drawing.Size(365, 720);
            this.Name = "FrmPrincipal";
            this.Text = "Pomodoro";
            this.TransparencyKey = System.Drawing.Color.DodgerBlue;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton restBtn;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton startBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton btnConfig;
    }
}

