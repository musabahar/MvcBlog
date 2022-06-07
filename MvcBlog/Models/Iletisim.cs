namespace MvcBlog.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Iletisim")]
    public partial class Iletisim
    {
        public int IletisimId { get; set; }

        [StringLength(250)]
        public string Adres { get; set; }

        [StringLength(250)]
        public string Telefon { get; set; }

        public string Fax { get; set; }

        public string Whatsapp { get; set; }

        public string Facebook { get; set; }

        public string Twitter { get; set; }

        public string Instagram { get; set; }
    }
}
