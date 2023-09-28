using crud_basico.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
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
                string apiUrl = string.Empty;

                if (string.IsNullOrEmpty(txtNome.Text))
                    apiUrl = $"http://localhost:3000/clientes";
                else
                    apiUrl = $"http://localhost:3000/clientes?nome={txtNome.Text}";

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

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Certifique-se de que uma célula válida foi clicada
            {
                DataGridViewRow selectedRow = dgvClientes.Rows[e.RowIndex];
                Cliente clienteSelecionado = new Cliente
                {
                    id = Convert.ToInt32(selectedRow.Cells[0].Value),
                    nome = selectedRow.Cells[1].Value.ToString(),
                    CPF = selectedRow.Cells[2].Value?.ToString(),
                    dataNascimento =
                    selectedRow.Cells[3].Value != null ? (DateTime)selectedRow.Cells[3].Value : null,
                    altura = (decimal)selectedRow.Cells[4].Value,
                    endereco = selectedRow.Cells[5].Value.ToString(),
                    idade = (int)selectedRow.Cells[6].Value,
                };

                frmCliente formCadastro = new frmCliente(clienteSelecionado);
                formCadastro.ShowDialog();
            }
        }
    }
}
