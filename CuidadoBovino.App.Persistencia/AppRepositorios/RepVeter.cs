using System;
using CuidadoBovino.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace CuidadoBovino.App.Persistencia
{
    public class RepVeter : IntVeter
    {
        
        private readonly AppContext _appContext; //definir contexto solo lectura y se relaciona con AppContext. Readonly es solo lectura no se puede cambiar
        public RepVeter(AppContext appContext)
        {
            _appContext = appContext;
        }
        Veterinario IntVeter.AddVeterinario(Veterinario veterinario)
        {
            var VeterinarioAdicionado = _appContext.Veterinarios.Add(veterinario);
            _appContext.SaveChanges();
            return VeterinarioAdicionado.Entity;
        }

        IEnumerable<Veterinario> IntVeter.GetAllVeterinarios()
        {
            return _appContext.Veterinarios;
        }
        Veterinario IntVeter.UpdateVeterinario(Veterinario veterinario)
        {
            var VeterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(V => V.Id == veterinario.Id);
            if (VeterinarioEncontrado != null)
            {
                VeterinarioEncontrado.Id = veterinario.Id;
                VeterinarioEncontrado.TarjProfesional = veterinario.TarjProfesional;
                VeterinarioEncontrado.Nombre = veterinario.Nombre;
                VeterinarioEncontrado.Direccion = veterinario.Direccion;
                VeterinarioEncontrado.Delefono = veterinario.Delefono;
                VeterinarioEncontrado.Correo = veterinario.Correo;
                
                _appContext.SaveChanges();
            }
            return VeterinarioEncontrado;
        }

        void IntVeter.DeleteVeterinario(int idVeterinario)
        {
            var VeterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.Id ==idVeterinario);
            if (VeterinarioEncontrado == null)
            {
                return;
            }
            _appContext.Veterinarios.Remove(VeterinarioEncontrado);
            _appContext.SaveChanges();
                
        }

        Veterinario IntVeter.GetVeterinario(int IdVeterinario)
        {
            return _appContext.Veterinarios.FirstOrDefault(v => v.Id == IdVeterinario);
        }
    }
}