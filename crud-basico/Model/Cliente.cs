using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace crud_basico.Model
{
    public class Cliente
    {
        //construtor vazio apenas para instância de novo objeto de cliente
        public Cliente()
        {
                
        }
        // Construtor que preenche as propriedades com base nos parâmetros
        public Cliente(int idParametro, string nomeParametro, string cpfParametro, DateTime dataNascimentoParametro, decimal alturaParametro, string enderecoParametro)
        {
            id = idParametro;
            nome = nomeParametro;
            CPF = cpfParametro;
            dataNascimento = dataNascimentoParametro;
            altura = alturaParametro;
            endereco = enderecoParametro;
        }

        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("nome")]
        public string? nome { get; set; }

        [JsonPropertyName("cpf")]
        public string? CPF { get; set; }

        [JsonPropertyName("dtNascimento")]
        public DateTime? dataNascimento { get; set; }

        [JsonPropertyName("altura")]
        public decimal altura { get; set; }

        [JsonPropertyName("endereco")]
        public string? endereco { get; set; }

        [JsonPropertyName("numEnd")]
        public int numEnd { get; set; }

        //MISSÃO: Fazer o cálculo
        //obrigatório, porém deve ser gerado atraves do calculo: (data atual - data de nascimento) = idade
        [JsonPropertyName("idade")]
        public int idade { get; set; }

    }
}
