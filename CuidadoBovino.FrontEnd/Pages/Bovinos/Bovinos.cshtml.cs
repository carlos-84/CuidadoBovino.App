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
      public class BovinosModel : PageModel
    {
        private readonly IntBovino RBovino;
        public IEnumerable<Bovino> Bovino{set;get;}
        public BovinosModel()
        {
            this.RBovino = new RepBovino(new CuidadoBovino.App.Persistencia.AppContext());
        }
        public void OnGet(string filtro)
        {
            Bovino = RBovino.GetAllBovinos();
        }
    }
}
