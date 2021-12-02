﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimeToStudy.Data.Context;

#nullable disable

namespace TimeToStudy.Data.Migrations
{
    [DbContext(typeof(TimeToStudyContext))]
    [Migration("20211130220403_ajustS")]
    partial class ajustS
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TimeToStudy.Domain.Entities.AgendaDeEstudo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreateAt")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("criado_em");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("SessaoDeEstudoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SessaoDeEstudoId")
                        .IsUnique();

                    b.ToTable("tb_agendaDeEstudo", (string)null);
                });

            modelBuilder.Entity("TimeToStudy.Domain.Entities.Conteudo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreateAt")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("criado_em");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("escricao");

                    b.Property<int>("MateriaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nome");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MateriaId");

                    b.ToTable("tb_conteudo", (string)null);
                });

            modelBuilder.Entity("TimeToStudy.Domain.Entities.Estudante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreateAt")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("criado_em");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("senha");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("sobrenome");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("tb_estudante", (string)null);
                });

            modelBuilder.Entity("TimeToStudy.Domain.Entities.Materia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreateAt")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("criado_em");

                    b.Property<int>("EstudanteId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nome");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EstudanteId");

                    b.ToTable("tb_materia", (string)null);
                });

            modelBuilder.Entity("TimeToStudy.Domain.Entities.Revisao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreateAt")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("criado_em");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("tb_revisao", (string)null);
                });

            modelBuilder.Entity("TimeToStudy.Domain.Entities.SessaoDeEstudo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AgendaDeEstudoId")
                        .HasColumnType("int");

                    b.Property<int>("AtividadesCorretas")
                        .HasColumnType("int")
                        .HasColumnName("atividadesCorretas");

                    b.Property<int>("AtividadesRealizadas")
                        .HasColumnType("int")
                        .HasColumnName("atividadesRealizadas");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("EstudanteId")
                        .HasColumnType("int");

                    b.Property<string>("TempoDuracao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("tempoDuracao");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EstudanteId");

                    b.ToTable("SessoesDeEstudos");
                });

            modelBuilder.Entity("TimeToStudy.Domain.Entities.AgendaDeEstudo", b =>
                {
                    b.HasOne("TimeToStudy.Domain.Entities.SessaoDeEstudo", "SessaoDeEstudo")
                        .WithOne("AgendaDeEstudo")
                        .HasForeignKey("TimeToStudy.Domain.Entities.AgendaDeEstudo", "SessaoDeEstudoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("SessaoDeEstudo");
                });

            modelBuilder.Entity("TimeToStudy.Domain.Entities.Conteudo", b =>
                {
                    b.HasOne("TimeToStudy.Domain.Entities.Materia", "Materia")
                        .WithMany("Conteudos")
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Materia");
                });

            modelBuilder.Entity("TimeToStudy.Domain.Entities.Materia", b =>
                {
                    b.HasOne("TimeToStudy.Domain.Entities.Estudante", "Estudante")
                        .WithMany("Materias")
                        .HasForeignKey("EstudanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estudante");
                });

            modelBuilder.Entity("TimeToStudy.Domain.Entities.SessaoDeEstudo", b =>
                {
                    b.HasOne("TimeToStudy.Domain.Entities.Estudante", "Estudante")
                        .WithMany("SessoesDeEstudos")
                        .HasForeignKey("EstudanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estudante");
                });

            modelBuilder.Entity("TimeToStudy.Domain.Entities.Estudante", b =>
                {
                    b.Navigation("Materias");

                    b.Navigation("SessoesDeEstudos");
                });

            modelBuilder.Entity("TimeToStudy.Domain.Entities.Materia", b =>
                {
                    b.Navigation("Conteudos");
                });

            modelBuilder.Entity("TimeToStudy.Domain.Entities.SessaoDeEstudo", b =>
                {
                    b.Navigation("AgendaDeEstudo")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}