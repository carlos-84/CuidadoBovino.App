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
    public class EditarDuenoModel : PageModel
    {
        private readonly IntDuenoBovino repDueno;
        [BindProperty]
        public DuenoBovino duenobovino{set;get;}
        public EditarDuenoModel()
        {
            this.repDueno = new RepDuenoBovino(new CuidadoBovino.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? IdEditarDueno)
        {
            if (IdEditarDueno.HasValue){
                duenobovino = repDueno.GetDuenoBovino(IdEditarDueno.Value);
           }
           else{
            duenobovino = new DuenoBovino(); 
           }
           if(duenobovino == null){
            return RedirectToPage("./NotFoundD");
           }
           else{
            return Page();
           }
        }
        public IActionResult OnPost()
        {
          if(!ModelState.IsValid)
          {
            return Page();
          }
          if(duenobovino.Id > 0)
          {
            duenobovino = repDueno.UpdateDuenoBovino(duenobovino);
          }
          else{
            repDueno.AddDuenoBovino(duenobovino);
          }
          return RedirectToPage("./Duenos");
        }
    }
}
