using CuidadoBovino.App.Dominio;
using System.Collections.Generic;
namespace CuidadoBovino.App.Persistencia 

{
    public interface IntDuenoBovino
    {
        IEnumerable<DuenoBovino> GetAllDuenoBovinos();
        DuenoBovino AddDuenoBovino(DuenoBovino duenobovino);
        DuenoBovino UpdateDuenoBovino(DuenoBovino duenobovino); 
        void DeleteDuenoBovino(int IdDuenoBovino);
        DuenoBovino GetDuenoBovino(int IdDuenoBovino);

    }

}