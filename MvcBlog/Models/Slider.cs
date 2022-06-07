namespace MvcBlog.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Slider")]
    public partial class Slider
    {
        public int SliderId { get; set; }

        [StringLength(30)]
        public string Baslik { get; set; }

        [StringLength(150)]
        public string Aciklama { get; set; }

        [StringLength(250)]
        public string ResimURL { get; set; }
    }
}
