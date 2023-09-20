using crud_basico.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_basico.View
{
    public partial class frmCliente : Form
    {
        private const string ViaCEPBaseUrl = "https://viacep.com.br/ws/";
        public frmCliente()
        {
            InitializeComponent();
        }

        private async void btnGravarCliente_Click(object sender, EventArgs e)
        {
            await this.GravarCliente();
        }

        private async void btnBuscaEndereco_Click(object sender, EventArgs e)
        {
            await this.ConsultarCep(txtCep.Text);

        }

        public Cliente ValidarClienteGravar(Cliente cliente)
        {
            try
            {
                if (cliente.Endereco != null)
                {
                    if (txtNumEnd.Text != null)
                    {
                        cliente.Endereco += $" {txtNumEnd}";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return cliente;
        }

        public async Task GravarCliente()
        {
            try
            {
                Cliente cliente = new Cliente();
                this.ValidarClienteGravar(cliente);

                using var httpClient = new HttpClient();

                HttpResponseMessage response = await httpClient.PostAsJsonAsync("http://localhost:3000/clientes", cliente);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Cliente {cliente.Nome} cadastrado com sucesso!");
                }
                else
                {
                    throw new Exception($"Erro ao cadastrar o cliente. Status Code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async Task ConsultarCep(string cep)
        {
            using var httpClient = new HttpClient();

            try
            {
                var apiUrl = $"{ViaCEPBaseUrl}{cep}/json/";
                var response = await httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                var jsonContent = await response.Content.ReadAsStringAsync();
                var endereco = JsonSerializer.Deserialize<Endereco>(jsonContent);
                if (endereco != null)
                {
                    this.PreencherEndereco(endereco);
                }
                else
                {
                    throw new Exception("Houve um erro ao tentar carregar um endereço para o CEP informado");
                }

            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Erro na consulta HTTP: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void PreencherEndereco(Endereco endereco)
        {
            txtEndereco.Text = endereco.Logradouro;
        }
    }
}
