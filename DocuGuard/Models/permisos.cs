using System.ComponentModel.DataAnnotations;

namespace DocuGuard.Models
{
    public class permisos
    {
        [Key]
        public int id_permisos {  get; set; }
        public int id_documentos { get; set; }
        public int id_usuario { get; set; }
        public string nivel_acceso { get; set; }
    }
}
