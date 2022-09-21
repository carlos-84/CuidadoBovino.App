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
    public class DetallesModel : PageModel
    {
        private readonly IntBovino repositorioB;
        public Bovino bovino {set; get;}
        public DetallesModel(){

            this.repositorioB = new RepBovino(new CuidadoBovino.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int idBovino)
        
        {
            bovino = repositorioB.GetBovino(idBovino);
            
          
            if (bovino==null)
            {
                return RedirectToPage("./NotFound");
               //Console.WriteLine("nada por aqui");
               //return null;
            }
            else{
               return Page();
            }
        }
    }
}
