﻿// <auto-generated />
using System;
using Blog.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blog.Data.Migrations
{
    [DbContext(typeof(MeuDbContext))]
    [Migration("20240927230757_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Blog.Business.Models.Autor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Biografia")
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Autor", (string)null);
                });

            modelBuilder.Entity("Blog.Business.Models.Comentario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Conteudo")
                        .IsRequired()
                        .HasColumnType("varchar(1000)");

                    b.Property<DateTime?>("DataPostagem")
                        .IsRequired()
                        .HasColumnType("datetime");

                    b.Property<Guid>("IdPostagem")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NomeAutor")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("IdPostagem");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Blog.Business.Models.Postagem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Conteudo")
                        .IsRequired()
                        .HasColumnType("varchar(1000)");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataCriacao")
                        .IsRequired()
                        .HasColumnType("datetime");

                    b.Property<Guid>("IdAutor")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("IdAutor");

                    b.ToTable("Postagem", (string)null);
                });

            modelBuilder.Entity("Blog.Business.Models.Comentario", b =>
                {
                    b.HasOne("Blog.Business.Models.Postagem", "Postagem")
                        .WithMany("Comentarios")
                        .HasForeignKey("IdPostagem")
                        .IsRequired();

                    b.Navigation("Postagem");
                });

            modelBuilder.Entity("Blog.Business.Models.Postagem", b =>
                {
                    b.HasOne("Blog.Business.Models.Autor", "Autor")
                        .WithMany("Postagens")
                        .HasForeignKey("IdAutor")
                        .IsRequired();

                    b.Navigation("Autor");
                });

            modelBuilder.Entity("Blog.Business.Models.Autor", b =>
                {
                    b.Navigation("Postagens");
                });

            modelBuilder.Entity("Blog.Business.Models.Postagem", b =>
                {
                    b.Navigation("Comentarios");
                });
#pragma warning restore 612, 618
        }
    }
}
