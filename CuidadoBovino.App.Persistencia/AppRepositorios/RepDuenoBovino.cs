
using System;
using CuidadoBovino.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace CuidadoBovino.App.Persistencia
{
    public class RepDuenoBovino : IntDuenoBovino
    {
        
        private readonly AppContext _appContext; //definir contexto solo lectura y se relaciona con AppContext. Readonly es solo lectura no se puede cambiar
        public RepDuenoBovino(AppContext appContext)
        {
            _appContext = appContext;
        }
        DuenoBovino IntDuenoBovino.AddDuenoBovino(DuenoBovino duenobovino)
        {
            var DuenoBovinoAdicionado = _appContext.DuenoBovinos.Add(duenobovino);
            _appContext.SaveChanges();
            return DuenoBovinoAdicionado.Entity;
        }

        IEnumerable<DuenoBovino> IntDuenoBovino.GetAllDuenoBovinos()
        {
            return _appContext.DuenoBovinos;
        }
        DuenoBovino IntDuenoBovino.UpdateDuenoBovino(DuenoBovino duenobovino)
        {
            var DuenoBovinoEncontrado = _appContext.DuenoBovinos.FirstOrDefault(DB => DB.Id == duenobovino.Id);
            if (DuenoBovinoEncontrado != null)
            {
                DuenoBovinoEncontrado.Id = duenobovino.Id;
                DuenoBovinoEncontrado.Nombre = duenobovino.Nombre;
                DuenoBovinoEncontrado.Apellido = duenobovino.Apellido;
                DuenoBovinoEncontrado.Direccion = duenobovino.Direccion;
                DuenoBovinoEncontrado.Telefono = duenobovino.Telefono;
                DuenoBovinoEncontrado.CorreoE = duenobovino.CorreoE;
                _appContext.SaveChanges();
            }
            return DuenoBovinoEncontrado;
        }

        void IntDuenoBovino.DeleteDuenoBovino(int idDuenoBovino)
        {
            var DuenoBovinoEncontrado = _appContext.DuenoBovinos.FirstOrDefault(db => db.Id ==idDuenoBovino);
            if (DuenoBovinoEncontrado == null)
            {
                return;
            }
            _appContext.DuenoBovinos.Remove(DuenoBovinoEncontrado);
            _appContext.SaveChanges();
                
        }

        DuenoBovino IntDuenoBovino.GetDuenoBovino(int IdDuenoBovino)
        {
            return _appContext.DuenoBovinos.FirstOrDefault(db => db.Id == IdDuenoBovino);
        }
    }
}