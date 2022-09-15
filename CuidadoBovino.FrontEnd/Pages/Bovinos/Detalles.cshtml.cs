using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CuidadoBovino.App.Dominio;
using CuidadoBovino.App.Persistencia;
using Microsoft.AspNetCore.Authorization;

namespace CuidadoBovino.FrontEnd.Pages
{
    public class DetallesModel : PageModel
    {
        private readonly IntBovino repositorioB;
        public Bovino bovino {set; get;}
        public DetallesModel(){
            this.repositorioB = new RepBovino(new CuidadoBovino.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int IdBovino)
        {
            bovino = repositorioB.GetBovino(IdBovino);
            if (bovino==null)
            {
                return RedirectToPage("./NoFound");
            }
            else{
               return Page();
            }
        }
    }
}
