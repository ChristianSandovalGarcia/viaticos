using System.ComponentModel.DataAnnotations;

namespace viaticos.Data
{
    public class departamentosModel
    {
        public int ID { get; set; }
        [Required]
        public string nombre { get; set; }
        public bool activo { get; set; }
    }
}