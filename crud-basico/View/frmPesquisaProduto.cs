using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_basico.View
{
    public partial class frmPesquisaProduto : Form
    {
        public frmPesquisaProduto()
        {
            InitializeComponent();
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            frmProduto frmProduto = new frmProduto();

            frmProduto.Show();
        }

        private async void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            await this.PesquisarProduto();
        }

        private async Task PesquisarProduto()
        {

        }

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
