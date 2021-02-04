using ExtraApp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtraApp.Services{
    public interface BreakingBad{
        Task<IEnumerable<Personaje>> getAllCharacters();
        Task<Personaje> GetPersonaje(int id);
    }
}