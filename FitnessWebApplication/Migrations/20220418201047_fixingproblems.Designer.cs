// <auto-generated />
using System;
using FitnessWebApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FitnessWebApplication.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220418201047_fixingproblems")]
    partial class fixingproblems
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FitnessWebApplication.Models.Classes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassCategory")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrainerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrainerId")
                        .IsUnique();

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("FitnessWebApplication.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassesId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateParticipation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Hour")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClassesId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("FitnessWebApplication.Models.Subscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("Validity")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("FitnessWebApplication.Models.Trainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClassesId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Trainers");
                });

            modelBuilder.Entity("FitnessWebApplication.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FitnessWebApplication.Models.User_Subscription", b =>
                {
                    b.Property<int>("SubscriptionId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("SubscriptionId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("User_Subcriptions");
                });

            modelBuilder.Entity("FitnessWebApplication.Models.Classes", b =>
                {
                    b.HasOne("FitnessWebApplication.Models.Trainer", "Trainer")
                        .WithOne("Classes")
                        .HasForeignKey("FitnessWebApplication.Models.Classes", "TrainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("FitnessWebApplication.Models.Reservation", b =>
                {
                    b.HasOne("FitnessWebApplication.Models.Classes", "Classes")
                        .WithMany("Reservations")
                        .HasForeignKey("ClassesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classes");
                });

            modelBuilder.Entity("FitnessWebApplication.Models.User", b =>
                {
                    b.HasOne("FitnessWebApplication.Models.Reservation", "Reservation")
                        .WithMany("Users")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("FitnessWebApplication.Models.User_Subscription", b =>
                {
                    b.HasOne("FitnessWebApplication.Models.Subscription", "Subscription")
                        .WithMany("User_Subscriptions")
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessWebApplication.Models.User", "User")
                        .WithMany("User_Subscriptions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subscription");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FitnessWebApplication.Models.Classes", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("FitnessWebApplication.Models.Reservation", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("FitnessWebApplication.Models.Subscription", b =>
                {
                    b.Navigation("User_Subscriptions");
                });

            modelBuilder.Entity("FitnessWebApplication.Models.Trainer", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("FitnessWebApplication.Models.User", b =>
                {
                    b.Navigation("User_Subscriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
