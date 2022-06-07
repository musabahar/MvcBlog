namespace MvcBlog.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hizmet")]
    public partial class Hizmet
    {
        public int HizmetId { get; set; }

        [Required]
        [StringLength(150)]
        public string Baslik { get; set; }

        public string Aciklama { get; set; }

        public string ResimURL { get; set; }
    }
}
