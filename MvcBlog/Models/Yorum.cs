namespace MvcBlog.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yorum")]
    public partial class Yorum
    {
        public int YorumId { get; set; }

        [Required]
        [StringLength(50)]
        public string AdSoyad { get; set; }

        public string Eposta { get; set; }

        public string Icerik { get; set; }

        public int? BlogId { get; set; }

        public bool Onay { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
