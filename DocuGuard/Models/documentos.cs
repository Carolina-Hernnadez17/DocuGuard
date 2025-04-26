using System;
using System.ComponentModel.DataAnnotations;

namespace DocuGuard.Models
{
    public class documentos
    {
        [Key]
        public int id_documento { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public string ruta_archivo { get; set; }
        public DateTime fecha_subida {  get; set; }
        public int version { get; set; }
        public string estado { get; set; }
       
    }
}
