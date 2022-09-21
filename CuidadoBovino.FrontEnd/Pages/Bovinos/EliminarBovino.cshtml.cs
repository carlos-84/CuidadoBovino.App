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
    public class EliminarBovinoModel : PageModel
    {
         private readonly IntBovino repoBovino;
        [BindProperty]
        public Bovino bovino{set;get;}

        public EliminarBovinoModel()
        {
            this.repoBovino=new RepBovino(new CuidadoBovino.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int idbovino)
        {
           bovino = repoBovino.GetBovino(idbovino);
           if(bovino == null){
            return RedirectToPage("./NotFound");
           }
           else{
            return Page();
           }
        }
        public IActionResult OnPost()
        {       
            repoBovino.DeleteBovino(bovino.Id);
            return RedirectToPage("./Bovinos");
        }
    }
}
