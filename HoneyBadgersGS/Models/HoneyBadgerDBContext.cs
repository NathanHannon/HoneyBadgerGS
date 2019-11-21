using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HoneyBadgers._0.Models
{
    public partial class HoneyBadgerDBContext : DbContext
    {
        public HoneyBadgerDBContext()
        {
        }

        public HoneyBadgerDBContext(DbContextOptions<HoneyBadgerDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<DeviceCodes> DeviceCodes { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Friendship> Friendship { get; set; }
        public virtual DbSet<Game> Game { get; set; }
        public virtual DbSet<PersistedGrants> PersistedGrants { get; set; }
        public virtual DbSet<Profile> Profile { get; set; }
        public virtual DbSet<Review> Review { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<Wishlist> Wishlist { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=HoneyBadgerDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.Property(e => e.CartId)
                    .HasColumnName("cartID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.FinalPrice).HasColumnName("finalPrice");

                entity.Property(e => e.GameId).HasColumnName("gameID");

                entity.Property(e => e.SubTotal).HasColumnName("subTotal");

                entity.Property(e => e.TaxRate).HasColumnName("taxRate");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.GameId)
                    .HasConstraintName("FK_Cart_gameID");
            });

            modelBuilder.Entity<DeviceCodes>(entity =>
            {
                entity.HasKey(e => e.UserCode);

                entity.Property(e => e.UserCode).HasMaxLength(200);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.DeviceCode)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SubjectId).HasMaxLength(200);
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.EventId)
                    .HasColumnName("eventID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId)
                    .HasColumnName("accountID");

                entity.Property(e => e.DateOfEvent)
                    .HasColumnName("dateOfEvent")
                    .HasColumnType("datetime");

                entity.Property(e => e.EventDescription)
                    .HasColumnName("eventDescription")
                    .HasColumnType("text");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Friendship>(entity =>
            {
                entity.Property(e => e.FriendshipId)
                    .HasColumnName("friendshipID")
                    .ValueGeneratedNever();

<<<<<<< HEAD
                entity.Property(e => e.AccountId).HasColumnName("accountID");
=======
                entity.Property(e => e.AccountId1)
                    .HasColumnName("accountId1")
                    .HasMaxLength(450);
                entity.Property(e => e.AccountId2)
                    .HasColumnName("accountId2")
                    .HasMaxLength(450);
                // entity.HasOne(d => d.AccountId)
                //     .WithMany(p => p.Account)
                //     .HasForeignKey(d => d.AccountId)
                //     .HasConstraintName("account_FK_FriendshipId");
>>>>>>> Sprint-3
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.Property(e => e.GameId)
                    .HasColumnName("gameID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Developer)
                    .HasColumnName("developer")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GameArtUrl)
                    .HasColumnName("gameArtUrl")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GameDescription)
                    .HasColumnName("gameDescription")
                    .HasColumnType("text");

                entity.Property(e => e.GameName)
                    .HasColumnName("gameName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Genre)
                    .HasColumnName("genre")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Platform)
                    .HasColumnName("platform")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Publisher)
                    .HasColumnName("publisher")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReleaseDate)
                    .HasColumnName("releaseDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemReq)
                    .HasColumnName("systemReq")
                    .HasColumnType("text");

                entity.Property(e => e.WishlistId).HasColumnName("wishlistID");

                entity.HasOne(d => d.Wishlist)
                    .WithMany(p => p.Game)
                    .HasForeignKey(d => d.WishlistId)
                    .HasConstraintName("FK_Game_Wishlist");
            });

            modelBuilder.Entity<PersistedGrants>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.Property(e => e.Key).HasMaxLength(200);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.SubjectId).HasMaxLength(200);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.Property(e => e.ProfileId).HasColumnName("profileID");

                entity.Property(e => e.ActualName)
                    .HasColumnName("actualName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasColumnName("displayName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileImage)
                    .HasColumnName("profileImage")
                    .HasColumnType("image");

                entity.Property(e => e.Promotion).HasColumnName("promotion");

                entity.Property(e => e.UserAddress)
                    .HasColumnName("userAddress")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.Property(e => e.ReviewId).HasColumnName("reviewID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("accountID")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.GameId).HasColumnName("gameID");

                entity.Property(e => e.RatingValue).HasColumnName("ratingValue");

                entity.Property(e => e.ReviewInfo)
                    .HasColumnName("reviewInfo")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.Review)
                    .HasForeignKey(d => d.GameId)
                    .HasConstraintName("PK_Review_gameID");
            });

            modelBuilder.Entity<Sales>(entity =>
            {
                entity.Property(e => e.SalesId)
                    .HasColumnName("salesID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId).HasColumnName("accountID");

                entity.Property(e => e.GameId).HasColumnName("gameID");

                entity.Property(e => e.TimeOfSales)
                    .HasColumnName("timeOfSales")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.GameId)
                    .HasConstraintName("FK_Sales_gameID");
            });

            modelBuilder.Entity<Wishlist>(entity =>
            {
                entity.Property(e => e.WishlistId)
                    .HasColumnName("wishlistId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId).HasColumnType("text");

                entity.Property(e => e.ItemInfo)
                    .HasColumnName("itemInfo")
                    .HasColumnType("text");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
