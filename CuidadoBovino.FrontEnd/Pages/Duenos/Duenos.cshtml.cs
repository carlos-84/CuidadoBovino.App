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
      public class DuenosModel : PageModel
    {
        private readonly IntDuenoBovino RepDueno;
        public IEnumerable<DuenoBovino> DuenoBovino{set;get;}
        public DuenosModel()
        {
            this.RepDueno = new RepDuenoBovino(new CuidadoBovino.App.Persistencia.AppContext());
        }
        public void OnGet(string filtro)
        {
            DuenoBovino = RepDueno.GetAllDuenoBovinos();
        }
    }
}
