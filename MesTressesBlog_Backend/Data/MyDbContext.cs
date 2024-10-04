using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) 
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleTranslation> ArticleTranslations { get; set; }
        public DbSet<BaseInfo> Base { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryTranslation> CategoriesTranslations { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentTranslation> DocumentTranslations { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<LevelTranslation> LevelTranslations { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentClassroom>()
                .HasKey(sc => new { sc.StudentId, sc.ClassroomId});

            modelBuilder.Entity<StudentClassroom>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudentClassrooms)
                .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<StudentClassroom>()
                .HasOne(sc => sc.Classroom)
                .WithMany(c => c.StudentClassrooms)
                .HasForeignKey(sc => sc.ClassroomId)
                .OnDelete(DeleteBehavior.Restrict); // Pas de suppression en cascade

            modelBuilder.Entity<Article>()
                .OwnsOne(s => s.BaseInfo);

            modelBuilder.Entity<ArticleTranslation>()
                .OwnsOne(s => s.BaseInfo);

            modelBuilder.Entity<Category>()
                .OwnsOne(s => s.BaseInfo);

            modelBuilder.Entity<CategoryTranslation>()
                .OwnsOne(s => s.BaseInfo);

            modelBuilder.Entity<Classroom>()
                .OwnsOne(s => s.BaseInfo);

            modelBuilder.Entity<Comment>()
                .OwnsOne(s => s.BaseInfo);

            modelBuilder.Entity<Competence>()
                .OwnsOne(s => s.BaseInfo);

            modelBuilder.Entity<Document>()
                .OwnsOne(s => s.BaseInfo);

            modelBuilder.Entity<DocumentTranslation>()
                .OwnsOne(s => s.BaseInfo);

            modelBuilder.Entity<Domain>()
                .OwnsOne(s => s.BaseInfo);

            modelBuilder.Entity<DomainTranslation>()
                .OwnsOne(s => s.BaseInfo);

            modelBuilder.Entity<Grade>()
                .OwnsOne(s => s.BaseInfo);

            modelBuilder.Entity<Language>()
                .OwnsOne(s => s.BaseInfo);

            modelBuilder.Entity<Level>()
                .OwnsOne(s => s.BaseInfo);

            modelBuilder.Entity<LevelTranslation>()
                .OwnsOne(s => s.BaseInfo);

            modelBuilder.Entity<Role>()
                .OwnsOne(s => s.BaseInfo);

            modelBuilder.Entity<Student>()
                .OwnsOne(s => s.BaseInfo);
        }
    }
}
