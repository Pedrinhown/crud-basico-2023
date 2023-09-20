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
        public Cliente(int id, string nome, string cpf, DateTime dataNascimento, decimal altura, string endereco)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            DataNascimento = dataNascimento;
            Altura = altura;
            Endereco = endereco;
        }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nome")]
        public string? Nome { get; set; }

        [JsonPropertyName("cpf")]
        public string? CPF { get; set; }

        [JsonPropertyName("dtNascimento")]
        public DateTime DataNascimento { get; set; }

        [JsonPropertyName("altura")]
        public decimal Altura { get; set; }

        [JsonPropertyName("endereco")]
        public string? Endereco { get; set; }

        //obrigatório, porém deve ser gerado atraves do calculo: (data atual - data de nascimento) = idade
        [JsonPropertyName("idade")]
        public int idade { get; set; }

    }
}
