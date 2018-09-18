using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using viaticos.Data;

namespace viaticos.Pages
{
    public class departamentosNuevo : PageModel
    {
        departamentosData departamentosData = new departamentosData();  
        [BindProperty]
        public departamentosModel departamento { get; set; }  
        public ActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            departamentosData.addDepartamento(departamento.nombre);
            return RedirectToPage("./departamentos");
        }
    }
}
