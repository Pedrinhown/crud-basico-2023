using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace crud_basico.Model
{
    public class Produto
    {
        public Produto()
        {
            
        }

        [JsonPropertyName("id")]
        public int id { get; set; }


        [JsonPropertyName("descricao")]
        public string descricao { get; set; }


        [JsonPropertyName("valor")]
        public decimal valor { get; set; }


        [JsonPropertyName("dataCadastro")]
        public DateTime? dataCadastro { get; set; }
    }
}
