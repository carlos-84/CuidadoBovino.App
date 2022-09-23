using CuidadoBovino.App.Dominio;
using System.Collections.Generic;
namespace CuidadoBovino.App.Persistencia 

{
    public interface IntVeter
    {
        IEnumerable<Veterinario> GetAllVeterinarios();
        Bovino AddVeterinario(Veterinario veterinario);
        Bovino UpdateVeterinario(Veterinario veterinario); 
        void DeleteVeterinario(int IdVeterinario);
        Bovino GetVeterinario(int IdVeterinario);

    }

}