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
    public class AgregarVetModel : PageModel
    {
        private readonly IntVeter repVeter;

        public AgregarVetModel()
        {
         this.repVeter = new RepVeter(new CuidadoBovino.App.Persistencia.AppContext());
        }
        [BindProperty]
        public Veterinario veterinario{set;get;}
        
       
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
          repVeter.AddVeterinario(veterinario);
          return RedirectToPage("./Veterinarios");
        }
        
    }
}
