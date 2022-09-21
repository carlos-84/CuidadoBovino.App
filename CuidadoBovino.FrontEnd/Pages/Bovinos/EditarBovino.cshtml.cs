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
    public class EditarBovinoModel : PageModel
    {
        private readonly IntBovino repoBovino;
        [BindProperty]
        public Bovino bovino{set;get;}
        public EditarBovinoModel()
        {
            this.repoBovino=new RepBovino(new CuidadoBovino.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? idbovino)
        {
            if (idbovino.HasValue){
                bovino = repoBovino.GetBovino(idbovino.Value);
           }
           else{
            bovino = new Bovino(); 
           }
           if(bovino == null){
            return RedirectToPage("./NotFound");
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
          if(bovino.Id > 0)
          {
            bovino = repoBovino.UpdateBovino(bovino);
          }
          else{
            repoBovino.AddBovino(bovino);
          }
          return RedirectToPage("./Bovinos");
        }
    }
}
