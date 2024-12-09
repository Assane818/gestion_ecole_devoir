﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebGestionDette.Data;

#nullable disable

namespace WebGestionEcole.Migrations
{
    [DbContext(typeof(WebGesEcoleContext))]
    [Migration("20241209095622_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebGestionEcole.Models.Absence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CoursId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("create_at");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("EtudiantId")
                        .HasColumnType("integer");

                    b.Property<int>("NbreHeure")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("update_at");

                    b.HasKey("Id");

                    b.HasIndex("CoursId");

                    b.HasIndex("EtudiantId");

                    b.ToTable("Absences");
                });

            modelBuilder.Entity("WebGestionEcole.Models.Classe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("create_at");

                    b.Property<string>("Filiere")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("update_at");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("WebGestionEcole.Models.Cours", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("create_at");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("Heure")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("HeureDebut")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("HeureFin")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Module")
                        .HasColumnType("integer");

                    b.Property<int>("ModuleId")
                        .HasColumnType("integer");

                    b.Property<int>("NombreHeures")
                        .HasColumnType("integer");

                    b.Property<int>("ProfesseurId")
                        .HasColumnType("integer");

                    b.Property<int>("Semestre")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("update_at");

                    b.HasKey("Id");

                    b.HasIndex("ProfesseurId");

                    b.ToTable("Cours");
                });

            modelBuilder.Entity("WebGestionEcole.Models.DetailCours", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ClasseId")
                        .HasColumnType("integer");

                    b.Property<int>("CoursId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("create_at");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("update_at");

                    b.HasKey("Id");

                    b.HasIndex("ClasseId");

                    b.HasIndex("CoursId");

                    b.ToTable("DetailCours");
                });

            modelBuilder.Entity("WebGestionEcole.Models.Etudiant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ClasseId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("create_at");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("update_at");

                    b.HasKey("Id");

                    b.HasIndex("ClasseId");

                    b.ToTable("Etudiants");
                });

            modelBuilder.Entity("WebGestionEcole.Models.Professeur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("create_at");

                    b.Property<int>("Grade")
                        .HasColumnType("integer");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Specialite")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("update_at");

                    b.HasKey("Id");

                    b.ToTable("Professeurs");
                });

            modelBuilder.Entity("WebGestionEcole.Models.Absence", b =>
                {
                    b.HasOne("WebGestionEcole.Models.Cours", "Cours")
                        .WithMany()
                        .HasForeignKey("CoursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebGestionEcole.Models.Etudiant", "Etudiant")
                        .WithMany("Absences")
                        .HasForeignKey("EtudiantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cours");

                    b.Navigation("Etudiant");
                });

            modelBuilder.Entity("WebGestionEcole.Models.Cours", b =>
                {
                    b.HasOne("WebGestionEcole.Models.Professeur", "Professeur")
                        .WithMany()
                        .HasForeignKey("ProfesseurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Professeur");
                });

            modelBuilder.Entity("WebGestionEcole.Models.DetailCours", b =>
                {
                    b.HasOne("WebGestionEcole.Models.Classe", "Classe")
                        .WithMany("CoursClasses")
                        .HasForeignKey("ClasseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebGestionEcole.Models.Cours", "Cours")
                        .WithMany("CoursClasses")
                        .HasForeignKey("CoursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classe");

                    b.Navigation("Cours");
                });

            modelBuilder.Entity("WebGestionEcole.Models.Etudiant", b =>
                {
                    b.HasOne("WebGestionEcole.Models.Classe", "Classe")
                        .WithMany()
                        .HasForeignKey("ClasseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classe");
                });

            modelBuilder.Entity("WebGestionEcole.Models.Classe", b =>
                {
                    b.Navigation("CoursClasses");
                });

            modelBuilder.Entity("WebGestionEcole.Models.Cours", b =>
                {
                    b.Navigation("CoursClasses");
                });

            modelBuilder.Entity("WebGestionEcole.Models.Etudiant", b =>
                {
                    b.Navigation("Absences");
                });
#pragma warning restore 612, 618
        }
    }
}
