using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using viaticos.Data;

namespace viaticos.Pages
{
    public class departamentos : PageModel
    {
        departamentosData departamentosData = new departamentosData();  
        public List<departamentosModel> dptos { get; set; }  
        public void OnGet()
        {
            dptos = departamentosData.getDepartamentos().ToList();
        }
    }
}
