
namespace crud_basico.View
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            await this.ExcluirProduto();
        }

        private async void btnGravarCliente_Click(object sender, EventArgs e)
        {
            await this.GravarProduto();
        }


        public async Task GravarProduto()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async Task ExcluirProduto()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
