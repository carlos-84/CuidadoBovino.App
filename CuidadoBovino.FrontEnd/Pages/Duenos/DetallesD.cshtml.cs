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
    public class DetallesDModel : PageModel
    {
        private readonly IntDuenoBovino repD;
        public DuenoBovino duenobovino {set; get;}
        public DetallesDModel(){

            this.repD = new RepDuenoBovino(new CuidadoBovino.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int idDueno)
        
        {
            duenobovino = repD.GetDuenoBovino(idDueno);
            
          
            if (duenobovino==null)
            {
                return RedirectToPage("./NoFound");
               
            }
            else{
               return Page();
            }
        }
    }
}
