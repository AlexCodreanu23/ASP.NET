using System;
using Lab3_23.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab3_23.Migrations
{
    [DbContext(typeof(Lab3Context))]
    partial class CoursesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Lab3_23.Models.Courses", b =>
            {
                b.Property<Guid>("CourseId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("Title")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Credits")
                    .HasColumnType("int");

                b.Property<DateTime>("StartDate")
                    .HasColumnType("datetime2");

                b.Property<string>("ProfessorName")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("CourseId");

                b.ToTable("Courses");
            });
        }
    }
}