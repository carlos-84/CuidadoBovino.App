using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CuidadoBovino.App.Dominio;
using CuidadoBovino.App.Persistencia;

namespace CuidadoBovino.FrontEnd.Pages
{
    public class AgregarBovinoModel : PageModel
    {
        private readonly IntBovino RBovino;

        public AgregarBovinoModel()
        {
         this.RBovino = new RepBovino(new CuidadoBovino.App.Persistencia.AppContext());
        }
        [BindProperty]
        public Bovino Bovino{set;get;}
        public Veterinario Veterinario{set; get;}
        public HistoriaMedica HistoriaMedica{set;get;}
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
          RBovino.AddBovino(Bovino);
          return RedirectToPage("./Bovinos");
        }
    }
}
