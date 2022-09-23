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
    public class EditarVetModel : PageModel
    {
        private readonly IntVeter repVet;
        [BindProperty]
        public Veterinario veterinario{set;get;}
        public EditarVetModel()
        {
            this.repVet = new RepVeter(new CuidadoBovino.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? IdEditarVet)
        {
            if (IdEditarVet.HasValue)
            {
                veterinario = repVet.GetVeterinario(IdEditarVet.Value);
            }
            else
            {
                veterinario = new Veterinario();
            }
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
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (veterinario.Id > 0)
            {
                veterinario = repVet.UpdateVeterinario(veterinario);
            }
            else
            {
                repVet.AddVeterinario(veterinario);
            }
            return RedirectToPage("./Veterinarios");
        }
    }
}
