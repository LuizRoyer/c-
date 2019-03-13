using System;
using System.Windows.Forms;

namespace SelecaoDeJogador
{
    public partial class TabelaJogador : Form
    {
        public TabelaJogador()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNovoJogador_Click(object sender, EventArgs e)
        {
            NovoJogador novoJogador = new NovoJogador();
            novoJogador.Show();
        }

        private void blnEditar_Click(object sender, EventArgs e)
        {
            // SelecaoDeJogador.Jogador

            //  foreach (DataGridViewRow row in dgvJogador.Rows)
            //{
            //if (row.Cells[0].Value)
            // {
            //  var codigo = Convert.ToString(row.Cells[1].Value); // linha do id
            //  jogadorBll.Deletar(codigo);



            // }
            //}
        }

        private void dgvJogador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var txtIdcategoria = Convert.ToString(this.dgvJogador.CurrentRow.Cells["idCategoria"].Value);

        }
    }
}