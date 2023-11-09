using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro.Properties
{
    public partial class FrmConfig : MetroFramework.Forms.MetroForm
    {
        public FrmConfig()
        {
            InitializeComponent();
        }
        private void txtPomoMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtLbreakInterval.Text) > 99 || int.Parse(txtBreakMin.Text) > 99 || int.Parse(txtPomoMin.Text) > 99 || int.Parse(txtLbreakMin.Text) > 99
                || int.Parse(txtLbreakInterval.Text) < 1 || int.Parse(txtBreakMin.Text) < 1 || int.Parse(txtPomoMin.Text) < 1 || int.Parse(txtLbreakMin.Text) < 1)
            {
                MessageBox.Show($"As caixas de texto aceitam apenas números entre 1 e 99", "Valor inserido inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                config.longBreakInterval = int.Parse(txtLbreakInterval.Text);
                config.minutoBreak = int.Parse(txtBreakMin.Text);
                config.minutoPomo = int.Parse(txtPomoMin.Text);
                config.minutoLongBreak = int.Parse(txtLbreakMin.Text);
                config.qualEstagioE = 0;
                this.Hide();
                new FrmPrincipal().ShowDialog();
                this.Close();
            }
            
        }
    }
}
