
using DotNetInterview.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotNetInterview.Data
{
    public class DotNetInterviewDbContext : IdentityDbContext
    {
        public DotNetInterviewDbContext(DbContextOptions<DotNetInterviewDbContext> options)
            : base(options)
        {
        }

        public DbSet<DNIUser> DNIUser { get; set; }

        public DbSet<Interview> Interviews { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Rank> Ranks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DNIUser>()
                .HasMany(u => u.Interviews)
                .WithOne(i => i.User)
                .HasForeignKey(i => i.UserId);

            modelBuilder.Entity<DNIUser>()
                .HasMany(u => u.Comments)
                .WithOne(c => c.User)
                .HasForeignKey(c => c.UserId);

            modelBuilder.Entity<DNIUser>()
                .HasMany(u => u.Ranks)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId);

            modelBuilder.Entity<Interview>()
                .HasMany(i => i.Questions)
                .WithOne(q => q.Interview)
                .HasForeignKey(q => q.InterviewId);

            modelBuilder.Entity<Interview>()
                .HasMany(i => i.Comments)
                .WithOne(c => c.Interview)
                .HasForeignKey(c => c.InterviewId);

            modelBuilder.Entity<Question>()
                .HasMany(q => q.Ranks)
                .WithOne(r => r.Question)
                .HasForeignKey(r => r.QuestionId);

            base.OnModelCreating(modelBuilder);
        }
    }
}