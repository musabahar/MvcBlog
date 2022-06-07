namespace MvcBlog.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kimlik")]
    public partial class Kimlik
    {
        public int KimlikId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(200)]
        public string Keywords { get; set; }

        [Required]
        [StringLength(300)]
        public string Description { get; set; }

        public string LogoURL { get; set; }

        public string Unvan { get; set; }
    }
}
