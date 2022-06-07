using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MvcBlog.Models
{
    public partial class MvcBlogDB : DbContext
    {
        public MvcBlogDB()
            : base("name=MvcBlogDB")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public virtual DbSet<Hizmet> Hizmets { get; set; }
        public virtual DbSet<Iletisim> Iletisims { get; set; }
        public virtual DbSet<Kategori> Kategoris { get; set; }
        public virtual DbSet<Kimlik> Kimliks { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }
        public virtual DbSet<Yorum> Yorums { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
