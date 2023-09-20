using crud_basico.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_basico.View
{
    public partial class frmPesquisaCliente : Form
    {
        public frmPesquisaCliente()
        {
            InitializeComponent();
        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
            await this.PesquisarCliente();
        }

        private async Task PesquisarCliente()
        {
            using var httpClient = new HttpClient();
            try
            {
                var apiUrl = $"http://localhost:3000/clientes";
                var response = await httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                var jsonContent = await response.Content.ReadAsStringAsync();
                var clientes = JsonSerializer.Deserialize<List<Cliente>>(jsonContent);
                if (clientes?.Count > 0)
                {
                    //exibir numa lista                    
                    dgvClientes.DataSource = clientes;
                }
                else
                {
                    dgvClientes.DataSource = new List<string>();
                    throw new Exception("Nenhum cliente encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();

            frmCliente.Show();

        }
    }
}
