
using System;
using CuidadoBovino.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace CuidadoBovino.App.Persistencia
{
    public class RepBovino : IntBovino
    {
        
        private readonly AppContext _appContext; //definir contexto solo lectura y se relaciona con AppContext. Readonly es solo lectura no se puede cambiar
        public RepBovino(AppContext appContext)
        {
            _appContext = appContext;
        }
        Bovino IntBovino.AddBovino(Bovino bovino)
        {
            var BovinoAdicionado = _appContext.Bovinos.Add(bovino);
            _appContext.SaveChanges();
            return BovinoAdicionado.Entity;
        }

        IEnumerable<Bovino> IntBovino.GetAllBovinos()
        {
            return _appContext.Bovinos;
        }

        Bovino IntBovino.GetBovino(int IdBovino)
        {
            return _appContext.Bovinos.FirstOrDefault(Bovino => Bovino.Id ==IdBovino);
        }

        Bovino IntBovino.UpdateBovino(Bovino bovino)
        {
            var BovinoEncontrado = _appContext.Bovinos.FirstOrDefault(Bovino => Bovino.Id == bovino.Id);
            if (BovinoEncontrado != null)
            {
                BovinoEncontrado.Id = bovino.Id;
                BovinoEncontrado.IdVeterinario = bovino.IdVeterinario;
                BovinoEncontrado.IdVisita = bovino.IdVisita;
                BovinoEncontrado.NombreBovino = bovino.NombreBovino;
                BovinoEncontrado.Color = bovino.Color;
                BovinoEncontrado.Raza = bovino.Raza;
                BovinoEncontrado.Edad = bovino.Edad;
                _appContext.SaveChanges();
            }
            return BovinoEncontrado;
        }

        void IntBovino.DeleteBovino(int idBovino)
        {
            var BovinoEncontrado = _appContext.Bovinos.FirstOrDefault(Bovino => Bovino.Id ==idBovino);
            if (BovinoEncontrado == null)
            {
                return;
            }
            _appContext.Bovinos.Remove(BovinoEncontrado);
            _appContext.SaveChanges();
                
        }
    }
}