using ExtraApp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExtraApp.Services{
    public class BreakingBad : IBreakingBad{

        private readonly HttpClient _httpClient;
        public BreakingBad(HttpClient httpclient){
            _httpClient = httpclient;
        }
        public async Task<IEnumerable<Personaje>> getAllCharacters(){
            return JsonConvert.DeserializableObject<IEnumerable<Personaje>>(
            await _httpClient.GetStringAsync($"characters/"));
        }
        Task<Personaje> GetPersonaje(int id){
             _httpClient.GetStringAsync($"characters/"+id);
        }

    }
}