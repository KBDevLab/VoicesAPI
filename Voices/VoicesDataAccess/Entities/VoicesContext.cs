using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccess.Models
{
    public partial class VoicesContext : DbContext
    {
        public VoicesContext()
        {
        }

        public VoicesContext(DbContextOptions<VoicesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PictureData> PictureData { get; set; }
        public virtual DbSet<PostData> PostData { get; set; }
        public virtual DbSet<PostDetails> PostDetails { get; set; }
        public virtual DbSet<Users> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PictureData>(entity =>
            {
                entity.HasKey(e => e.PictureId);

                entity.Property(e => e.PictureId).HasColumnName("PictureID");

                entity.Property(e => e.ImgDate)
                    .HasColumnName("imgDate")
                    .HasColumnType("date");

                entity.Property(e => e.ImgName)
                    .HasColumnName("imgName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImgSource).HasColumnName("imgSource");
            });

            modelBuilder.Entity<PostData>(entity =>
            {
                entity.HasKey(e => e.PostId);

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.Comment)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Title)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PostDetails>(entity =>
            {
                entity.HasKey(e => e.DetailsId);

                entity.Property(e => e.DetailsId).HasColumnName("DetailsID");

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostDetails)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostDetails_PostData");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PostDetails)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostDetails_Users");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.PostsNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Posts)
                    .HasConstraintName("FK_Users_PostData");

                entity.HasOne(d => d.ProfilePicNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.ProfilePic)
                    .HasConstraintName("FK_Users_PictureData");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
