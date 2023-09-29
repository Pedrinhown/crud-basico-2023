using System.Text.Json.Serialization;

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
