using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdditionBonusTask.Areas.Identity.Data;
using AdditionBonusTask.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AdditionBonusTask.Data
{
    public class AuthDbContext : IdentityDbContext<ApplicationUser>
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options)
            : base(options)
        {
        }

        public AuthDbContext() { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>()
                .HasMany<Post>(s => s.Posts)
                .WithOne(g => g.User)
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ApplicationUser>()
                .HasMany<Message>(s => s.Messages)
                .WithOne(g => g.User)
                .HasForeignKey(s => s.UserSenderId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ApplicationUser>()
                .HasMany<Message>(s => s.Messages)
                .WithOne(g => g.User)
                .HasForeignKey(s => s.UserReceiverId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ApplicationUser>()
               .HasMany<Friend>(s => s.Friends)
               .WithOne(g => g.User)
               .HasForeignKey(s => s.FriendSenderId)
               .OnDelete(DeleteBehavior.Cascade);


            builder.Entity<Post>()
                .HasMany<Comment>(s => s.Comments)
                .WithOne(g => g.Post)
                .HasForeignKey(s => s.PostId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ApplicationUser>()
                .HasMany<Comment>(s => s.Comments)
                .WithOne(g => g.User)
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }


       public DbSet<Post> Posts { get; set; }
       public DbSet<Message> Messages { get; set; }
       public DbSet<Friend> Friends { get; set; }
       public DbSet<Comment> Comments { get; set; }

    }
}
