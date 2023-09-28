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
        public frmCliente(Cliente cliente)
        {
            InitializeComponent();

            txtId.Text = cliente.id.ToString();
            txtNome.Text = cliente.nome;
            txtCpf.Text = cliente.CPF;
            txtDtNascimento.Text = cliente.dataNascimento.Value.ToShortDateString();
            txtAltura.Text = cliente.altura.ToString();
            txtIdadePessoa.Text = (DateTime.Now.Year - cliente.dataNascimento.Value.Year).ToString();

            txtEndereco.Text = cliente.endereco;
            txtNumEnd.Text = cliente.numEnd.ToString();
        }

        private async void btnGravarCliente_Click(object sender, EventArgs e)
        {
            await this.GravarCliente();
        }

        private async void btnBuscaEndereco_Click(object sender, EventArgs e)
        {
            await this.ConsultarCep(txtCep.Text);

        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            await this.ExcluirCliente();
        }


        public Cliente ValidarClienteGravar(Cliente cliente)
        {
            try
            {
                if (string.IsNullOrEmpty(cliente.nome))
                    throw new Exception("Informe o nome do cliente!");

                if (string.IsNullOrEmpty(cliente.CPF))
                    throw new Exception("Informe o cpf do cliente!");

                if (!cliente.dataNascimento.HasValue)
                    throw new Exception("Informe a data de nascimento do cliente!");
                else
                    cliente.idade = DateTime.Now.Year - cliente.dataNascimento.Value.Year;

                if (cliente.altura <= 0)
                    throw new Exception("Informe a altura do cliente!");

                if (string.IsNullOrEmpty(cliente.endereco))
                    throw new Exception("Informe o endereço do cliente!");

                if (cliente.numEnd <= 0)
                    throw new Exception("Informe o número para o endereço do cliente!");

                if (cliente.endereco != null)
                {
                    if (txtNumEnd.Text != null)
                    {
                        cliente.endereco += $" {txtNumEnd.Text}";
                    }
                    else
                    {
                        throw new Exception("Informe o número do endereço do cliente!");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cliente;
        }

        public async Task GravarCliente()
        {
            try
            {
                decimal.TryParse(txtAltura.Text, out decimal altura);
                int.TryParse(txtId.Text, out int id);
                int.TryParse(txtNumEnd.Text, out int numEnd);
                Cliente cliente = new Cliente(id, txtNome.Text, txtCpf.Text, Convert.ToDateTime(txtDtNascimento.Text), altura, $"{txtEndereco.Text}, {txtNumEnd.Text}", numEnd);
                this.ValidarClienteGravar(cliente);

                using var httpClient = new HttpClient();

                HttpResponseMessage response = await httpClient.PostAsJsonAsync("http://localhost:3000/clientes", cliente);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Cliente {cliente.nome} cadastrado/atualizado com sucesso!");
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
                MessageBox.Show($"Erro na consulta HTTPS: {ex.Message}");
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

        private async Task ExcluirCliente()
        {
            try
            {
                if (txtId.Text == string.Empty)
                {
                    throw new Exception("É necessário estar com um cliente selecionado para efetuar a exclusão!");
                }

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.DeleteAsync($"http://localhost:3000/clientes/{txtId.Text}");

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Cliente {txtNome.Text} foi excluído com sucesso.");
                        this.Close();
                    }
                    else
                    {
                        throw new Exception($"Falha ao excluir o cliente {txtNome.Text}. Status Code: {response.StatusCode}");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
