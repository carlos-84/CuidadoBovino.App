using CuidadoBovino.App.Dominio;
using System.Collections.Generic;
namespace CuidadoBovino.App.Persistencia 

{
    public interface IntBovino 
    {
        IEnumerable<Bovino> GetAllBovinos();
        Bovino AddBovino(Bovino bovino);
        Bovino UpdateBovino(Bovino bovino); 
        void DeleteBovino(int IdBovino);
        Bovino GetBovino(int IdBovino);

    }

}