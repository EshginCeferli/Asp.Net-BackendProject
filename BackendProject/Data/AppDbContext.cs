using BackendProject.Models;
using EntityFrameworkProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductHeader> ProductHeaders { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogHeader> BlogHeaders { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Widget> Widgets { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<TopHeader> TopHeaders { get; set; }
        public DbSet<RelatedHeader> RelatedHeaders { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Setting> Settings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Slider>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Link>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Product>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<ProductImage>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<ProductHeader>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Banner>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Blog>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<BlogHeader>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Brand>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Widget>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Social>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Category>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Tag>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Contact>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<TopHeader>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<RelatedHeader>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Color>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Size>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Setting>().HasQueryFilter(m => !m.IsDeleted);
        }
    }
}
