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
    public class DetallesVetModel : PageModel
    {
        private readonly IntVeter repositorioV;
        public Veterinario veterinario {set; get;}
        public DetallesVetModel(){

            this.repositorioV = new RepVeter(new CuidadoBovino.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int idVeterinario)
        
        {
            veterinario = repositorioV.GetVeterinario(idVeterinario);
            
          
            if (veterinario==null)
            {
                return RedirectToPage("./NotFound");
               
            }
            else{
               return Page();
            }
        }
    }
}
