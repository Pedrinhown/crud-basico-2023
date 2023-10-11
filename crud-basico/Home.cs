using crud_basico.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_basico
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmPesquisaCliente frmCli = new frmPesquisaCliente();
            frmCli.Show();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto frmProd = new frmPesquisaProduto();
            frmProd.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //eu modifiquei isso aqui, prove me que não fui eu :) !!
            //eu modifiquei isso aqui, prove me que não fui eu :) !!
            //eu modifiquei isso aqui, prove me que não fui eu :) !!

            //eu modifiquei isso aqui, prove me que não fui eu :) !!
        }
    }
}
