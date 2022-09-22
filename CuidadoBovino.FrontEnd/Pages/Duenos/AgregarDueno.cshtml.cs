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
    public class AgregarDuenoModel : PageModel
    {
        private readonly IntDuenoBovino repDueno;

        public AgregarDuenoModel()
        {
         this.repDueno = new RepDuenoBovino(new CuidadoBovino.App.Persistencia.AppContext());
        }
        [BindProperty]
        public DuenoBovino duenobovino{set;get;}
               
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
          repDueno.AddDuenoBovino(duenobovino);
          return RedirectToPage("./Duenos");
        }
        
    }
}
