using CuidadoBovino.App.Dominio;
using System.Collections.Generic;
namespace CuidadoBovino.App.Persistencia 

{
    public interface IntVeter
    {
        IEnumerable<Veterinario> GetAllVeterinarios();
        Veterinario AddVeterinario(Veterinario veterinario);
        Veterinario UpdateVeterinario(Veterinario veterinario); 
        void DeleteVeterinario(int IdVeterinario);
        Veterinario GetVeterinario(int IdVeterinario);

    }

}