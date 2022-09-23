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
    public class EliminarDuenoModel : PageModel
    {
        private readonly IntDuenoBovino repDueno;
        [BindProperty]
        public DuenoBovino duenobovino{set;get;}

        public EliminarDuenoModel()
        {
             this.repDueno = new RepDuenoBovino(new CuidadoBovino.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int IdEliminarDueno)
        {
            duenobovino = repDueno.GetDuenoBovino(IdEliminarDueno);
            if (duenobovino == null)
            {
                return RedirectToPage("./NotFoundD");
            }
            else{
            return Page();
           }
        }
        public IActionResult OnPost()
        {
            repDueno.DeleteDuenoBovino(duenobovino.Id);
            return RedirectToPage("./Duenos");
        }
    }
}
