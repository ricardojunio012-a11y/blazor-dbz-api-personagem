using System.Net;
using System.Net.Http.Json;
using BlazorDbzPersonagem.Models;

namespace BlazorDbzPersonagem.Services
{
    public class PersonagemService
    {
        private readonly HttpClient _httpClient;

        public PersonagemService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Consome o endpoint https://dragonball-api.com/api/characters/{id}
        // Retorna null quando a API não encontra o personagem
        public async Task<Personagem?> GetPersonagemAsync(int id)
        {
            var resposta = await _httpClient.GetAsync($"api/characters/{id}");

            if (resposta.StatusCode == HttpStatusCode.NotFound || resposta.StatusCode == HttpStatusCode.BadRequest)
            {
                return null;
            }

            resposta.EnsureSuccessStatusCode();
            return await resposta.Content.ReadFromJsonAsync<Personagem>();
        }
    }
}
