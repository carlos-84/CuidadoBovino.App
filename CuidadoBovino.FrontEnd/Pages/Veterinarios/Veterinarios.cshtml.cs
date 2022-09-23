using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CuidadoBovino.App.Dominio;
using CuidadoBovino.App.Persistencia;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuidadoBovino.FrontEnd.Pages
{
      public class VeterinariosModel : PageModel
    {
        private readonly IntVeter repVeter;
        public IEnumerable<Veterinario> Veterinario{set;get;}
        public VeterinariosModel()
        {
            this.repVeter = new RepVeter(new CuidadoBovino.App.Persistencia.AppContext());
        }
        public void OnGet(string filtro)
        {
            Veterinario = repVeter.GetAllVeterinarios();
        }
    }
}
