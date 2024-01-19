﻿// <auto-generated />
using DigitalHub.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DigitalHub.Migrations
{
    [DbContext(typeof(MyDataContext))]
    [Migration("20240117140454_firs_migration")]
    partial class firs_migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DigitalHub.Models.Assessment_Questions_Relation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("assesment_id")
                        .HasColumnType("int");

                    b.Property<int>("question_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("assesment_id");

                    b.HasIndex("question_id");

                    b.ToTable("Assessment_Questions_Relations");
                });

            modelBuilder.Entity("DigitalHub.Models.Assessment_enrols", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Result")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int>("User_id")
                        .HasColumnType("int");

                    b.Property<int>("assessment_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("User_id");

                    b.HasIndex("assessment_id");

                    b.ToTable("Assessment_Enrols");
                });

            modelBuilder.Entity("DigitalHub.Models.Assessments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Assessments");
                });

            modelBuilder.Entity("DigitalHub.Models.Assessments_Questions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Assessments_Questions");
                });

            modelBuilder.Entity("DigitalHub.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DigitalHub.Models.Assessment_Questions_Relation", b =>
                {
                    b.HasOne("DigitalHub.Models.Assessments", "Assessments")
                        .WithMany("Assessment_Questions_Relations")
                        .HasForeignKey("assesment_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DigitalHub.Models.Assessments_Questions", "Assessments_Questions")
                        .WithMany("Assessment_Questions_Relations")
                        .HasForeignKey("question_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assessments");

                    b.Navigation("Assessments_Questions");
                });

            modelBuilder.Entity("DigitalHub.Models.Assessment_enrols", b =>
                {
                    b.HasOne("DigitalHub.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("User_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DigitalHub.Models.Assessments", "Assessments")
                        .WithMany()
                        .HasForeignKey("assessment_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assessments");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DigitalHub.Models.Assessments", b =>
                {
                    b.Navigation("Assessment_Questions_Relations");
                });

            modelBuilder.Entity("DigitalHub.Models.Assessments_Questions", b =>
                {
                    b.Navigation("Assessment_Questions_Relations");
                });
#pragma warning restore 612, 618
        }
    }
}
