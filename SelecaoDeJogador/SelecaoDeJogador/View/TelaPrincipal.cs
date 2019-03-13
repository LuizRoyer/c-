using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelecaoDeJogador
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            NovoJogador novoJogador = new NovoJogador();
            novoJogador.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            TabelaJogador tabelaJogador = new TabelaJogador();
            tabelaJogador.Show();
        }
    }
}
