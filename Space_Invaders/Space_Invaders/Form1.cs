using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Invaders
{
    public partial class Form1 : Form
    {
        private List<Button> ListaBotao = new List<Button>();
        Int64 totalTiros = 0;
        Int64 totalAcertos = 0;

        public Form1()
        {
            InitializeComponent();
            pBNave.Location = Location = new Point(88, 320);
            MaximizeBox = false;
        }

        public void MoverNave(String direcao)
        {
            var PosicaoDireita = Form1.ActiveForm.Size.Width - pBNave.Size.Width;
            var PosicaoEsquerda = -20;

            if (direcao == "L")
            {
                if (pBNave.Left >= PosicaoEsquerda) pBNave.Left -= 20;
            }
            else
            {
                if (pBNave.Left < PosicaoDireita) pBNave.Left += 20;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    MoverNave("L");
                    break;
                case Keys.Right:
                    MoverNave("R");
                    break;

                case Keys.Space:
                    System.Threading.Thread t = new System.Threading.Thread(MoverTiro);
                    t.Start();

                    break;
                default:
                    break;
            }
        }

        public void MoverTiro()
        {
            PictureBox _pbTiro = new PictureBox
            {
                Image = pBTiro.Image,
                Visible = true
            };

            _pbTiro.Visible = true;

            var posicaoTiro = pBNave.Left + 25;
            var alturaTiro = 320;
            _pbTiro.Location = pBNave.Location;

            this.Invoke(new MethodInvoker(delegate { this.Controls.Add((Control)_pbTiro); }));

            Boolean verifica = true;
            totalTiros += 1;

            while (_pbTiro.Location.Y < 10000)
            {
                _pbTiro.Invoke(new MethodInvoker(delegate { lBTiro.Text = "ToTal De Tiros    " + Convert.ToString(totalTiros); }));

                _pbTiro.Invoke(new MethodInvoker(delegate { _pbTiro.Location = new Point(posicaoTiro, alturaTiro); }));
                alturaTiro -= 20;
                Application.DoEvents();

                System.Threading.Thread.Sleep(50);

                foreach (Button buttao in ListaBotao)
                {
                    var LimiteBt = buttao.Location.X - buttao.Size.Width;
                    var meioTiro = _pbTiro.Location.X - (_pbTiro.Size.Width/10);

                    if (buttao.Visible)
                    {
                        if (meioTiro > LimiteBt && meioTiro < buttao.Location.X)
                        {
                            if (_pbTiro.Location.Y <= buttao.Location.Y)
                            {
                                buttao.Invoke(new MethodInvoker(delegate { buttao.Visible = false; }));
                                verifica = false;
                                totalAcertos += 1;
                                lBacerto.Invoke(new MethodInvoker(delegate {lBacerto.Text ="Total De Acertos "+Convert.ToString(totalAcertos); }));
                                break;
                            }
                        }
                    }
                }

                if (!verifica)
                {
                    break;
                }
            }
            _pbTiro.Invoke(new MethodInvoker(delegate { _pbTiro.Dispose(); }));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pBNave.Focus();

            foreach (Control control in Controls)
            {
                if (control.Name.IndexOf("button") >= 0)
                {
                    ListaBotao.Add((Button)control);
                }
            }
        }
    }
}
