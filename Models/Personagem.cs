using System.Text.Json.Serialization;

namespace BlazorDbzPersonagem.Models
{
    public class Personagem
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Nome { get; set; } = string.Empty;

        [JsonPropertyName("image")]
        public string Imagem { get; set; } = string.Empty;

        [JsonPropertyName("originPlanet")]
        public Planeta? Planeta { get; set; }

        [JsonPropertyName("transformations")]
        public List<Transformacao> Transformacoes { get; set; } = new();
    }

    public class Planeta
    {
        [JsonPropertyName("name")]
        public string Nome { get; set; } = string.Empty;
    }

    public class Transformacao
    {
        [JsonPropertyName("name")]
        public string Nome { get; set; } = string.Empty;

        [JsonPropertyName("ki")]
        public string Ki { get; set; } = string.Empty;
    }
}
