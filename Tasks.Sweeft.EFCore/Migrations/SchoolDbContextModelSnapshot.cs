﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tasks.Sweeft.EFCore;

#nullable disable

namespace Tasks.Sweeft.EFCore.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    partial class SchoolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Tasks.Sweeft.EFCore.Models.Pupil", b =>
                {
                    b.Property<int>("PupilID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PupilID"));

                    b.Property<int>("Class")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PupilID");

                    b.ToTable("Pupils");
                });

            modelBuilder.Entity("Tasks.Sweeft.EFCore.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherID"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherID");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Tasks.Sweeft.EFCore.Models.TeacherPupil", b =>
                {
                    b.Property<int>("TeacherID")
                        .HasColumnType("int");

                    b.Property<int>("PupilID")
                        .HasColumnType("int");

                    b.HasKey("TeacherID", "PupilID");

                    b.HasIndex("PupilID");

                    b.ToTable("TeacherPupils");
                });

            modelBuilder.Entity("Tasks.Sweeft.EFCore.Models.TeacherPupil", b =>
                {
                    b.HasOne("Tasks.Sweeft.EFCore.Models.Pupil", "Pupil")
                        .WithMany("TeacherPupils")
                        .HasForeignKey("PupilID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tasks.Sweeft.EFCore.Models.Teacher", "Teacher")
                        .WithMany("TeacherPupils")
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pupil");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Tasks.Sweeft.EFCore.Models.Pupil", b =>
                {
                    b.Navigation("TeacherPupils");
                });

            modelBuilder.Entity("Tasks.Sweeft.EFCore.Models.Teacher", b =>
                {
                    b.Navigation("TeacherPupils");
                });
#pragma warning restore 612, 618
        }
    }
}
