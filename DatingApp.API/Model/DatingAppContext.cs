using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DatingApp.API.Model
{
    public partial class DatingAppContext : DbContext
    {
        public DatingAppContext()
        {
        }

        public DatingAppContext(DbContextOptions<DatingAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Likes> Likes { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Value> Value { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=DatingApp;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity<Likes>(entity =>
            {
                entity.HasOne(d => d.Likee)
                    .WithMany(p => p.LikesLikee)
                    .HasForeignKey(d => d.LikeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LikeeId");

                entity.HasOne(d => d.Liker)
                    .WithMany(p => p.LikesLiker)
                    .HasForeignKey(d => d.LikerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_likerId");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.Content).IsUnicode(false);

                entity.Property(e => e.DateRead).HasColumnType("datetime");

                entity.Property(e => e.IsRead)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.MessageSent)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecipientDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.SenderDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.HasOne(d => d.Recipient)
                    .WithMany(p => p.MessageRecipient)
                    .HasForeignKey(d => d.RecipientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecipientId");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.MessageSender)
                    .HasForeignKey(d => d.SenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SenderId");
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.PublicId)
                    .HasColumnName("PublicID")
                    .IsUnicode(false);

                entity.Property(e => e.Url).IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Photo)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserId");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.City)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.Gender)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Interests)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Introduction).IsUnicode(false);

                entity.Property(e => e.KnownAs)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.LastActive).HasColumnType("datetime");

                entity.Property(e => e.LookingFor)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Value>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).IsUnicode(false);
            });
        }
    }
}
