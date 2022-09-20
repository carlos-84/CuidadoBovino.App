using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CuidadoBovino.App.Dominio;
using CuidadoBovino.App.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CuidadoBovino.FrontEnd.Pages
{
    public class AgregarBovinoModel : PageModel
    {
        private readonly IntBovino repBovino;

        public AgregarBovinoModel()
        {
            this.repBovino = new RepBovino(new CuidadoBovino.App.Persistencia.AppContext());
        }
        [BindProperty]
        public Bovino bovino{set;get;}
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            repBovino.AddBovino(bovino);
            return RedirectToPage("./Bovinos");
        }
    }
}
