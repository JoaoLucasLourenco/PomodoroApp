using Pomodoro.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro
{
    public partial class FrmPrincipal : MetroFramework.Forms.MetroForm
    {
        private int minutos = config.minutoPomo;
        private int segundos = 0;
        private int contaVez = 0;
        

        public FrmPrincipal()
        {
            InitializeComponent();
            FormatoLabel1();
        }
        private void ResetTimer(string btnText)
        {
            timer1.Enabled = false;

            minutos = btnText == "START" ? config.minutoPomo : btnText == "BREAK" ? config.minutoBreak : btnText == "LONG BREAK" ? config.minutoLongBreak : 
                btnText == "FOCUS" ? config.minutoPomo : 0; 
            segundos = 0;
            startBtn.Text = "START";
            FormatoLabel1();
        }
        private void atualizaContaVez()
        {
            contaVez++;
            label2.Text = $"#{contaVez}";
        }
        private void FormatoLabel1()
        {
            label1.Text = string.Format("{0:00}:{1:00}", minutos, segundos);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            startBtn.Text = startBtn.Text == "START" ? "STOP" : "START";
            timer1.Enabled = startBtn.Text == "STOP" ? true : false;
        }
        
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (minutos == 0 && segundos == 0)
            {
                switch (config.qualEstagioE) 
                {
                    case 0:
                        string textoBotao = contaVez % config.longBreakInterval == 0 ? "BREAK" : "LONG BREAK";
                        ResetTimer(textoBotao);
                        atualizaContaVez();
                        panel1.BackColor = contaVez % config.longBreakInterval == 0 ? Color.SteelBlue : Color.DarkSeaGreen;
                        MessageBox.Show("Tempo esgotado!");
                        config.qualEstagioE = contaVez % config.longBreakInterval == 0 ? 2 : 1;
                        break;
                    case 1:
                        ResetTimer(metroButton2.Text);
                        panel1.BackColor = Color.LightCoral;
                        config.qualEstagioE = 0;
                        MessageBox.Show("Tempo Esgotado!");
                        break;
                    case 2:
                        ResetTimer(metroButton2.Text);
                        panel1.BackColor = Color.LightCoral;
                        config.qualEstagioE = 0;
                        MessageBox.Show("Tempo Esgotado!");
                        break;
                }
            }
            else
            {
                if (segundos == 0)
                {
                    minutos--;
                    segundos = 59;
                }
                else
                {
                    segundos--;
                }

                FormatoLabel1();
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Hide();
            new FrmConfig().ShowDialog();
            this.Close();
        }

        private void restBtn_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DarkSeaGreen;
            ResetTimer(restBtn.Text);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LightCoral;
            ResetTimer(metroButton2.Text);
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.SteelBlue;
            ResetTimer(metroButton4.Text);
        }
    }
}
