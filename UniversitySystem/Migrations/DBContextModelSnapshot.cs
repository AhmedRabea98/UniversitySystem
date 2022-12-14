// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniversitySystem.Models;

namespace UniversitySystem.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("UniversitySystem.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CodeAr")
                        .HasColumnType("text");

                    b.Property<string>("CodeEn")
                        .HasColumnType("text");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Grade")
                        .HasColumnType("text");

                    b.Property<string>("Hours")
                        .HasColumnType("text");

                    b.Property<int>("MaxNum")
                        .HasColumnType("int");

                    b.Property<string>("NameAr")
                        .HasColumnType("text");

                    b.Property<string>("NameEn")
                        .HasColumnType("text");

                    b.Property<string>("Prerequisite")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("UniversitySystem.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("UniversitySystem.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Gpa")
                        .HasColumnType("text");

                    b.Property<string>("NameAr")
                        .HasColumnType("text");

                    b.Property<string>("NameEn")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("UniversitySystem.Models.StudentCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentCourse");
                });

            modelBuilder.Entity("UniversitySystem.Models.Course", b =>
                {
                    b.HasOne("UniversitySystem.Models.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("UniversitySystem.Models.Student", b =>
                {
                    b.HasOne("UniversitySystem.Models.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("UniversitySystem.Models.StudentCourse", b =>
                {
                    b.HasOne("UniversitySystem.Models.Course", "course")
                        .WithMany("Students")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversitySystem.Models.Student", "student")
                        .WithMany("Courses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("course");

                    b.Navigation("student");
                });

            modelBuilder.Entity("UniversitySystem.Models.Course", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("UniversitySystem.Models.Department", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("UniversitySystem.Models.Student", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
