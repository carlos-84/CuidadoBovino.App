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
    public class EliminarVetModel : PageModel
    {
        private readonly IntVeter repVet;
        [BindProperty]
        public Veterinario veterinario{set;get;}

        public EliminarVetModel()
        {
            this.repVet = new RepVeter(new CuidadoBovino.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int IdEliminarVet)
        {
            veterinario = repVet.GetVeterinario(IdEliminarVet);
            if (veterinario == null)
            {
                return RedirectToPage("./NotFoundV");
            }
            else{
            return Page();
           }
        }
        public IActionResult OnPost()
        {
            repVet.DeleteVeterinario(veterinario.Id);
            return RedirectToPage("./Veterinarios");
        }
    }
}
