﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppServer1;

#nullable disable

namespace WebAppServer1.Migrations
{
    [DbContext(typeof(WebServerContext))]
    [Migration("20220606134219_newDb2")]
    partial class newDb2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ServerFreak.Models.Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ContactId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserFUsername")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserFUsername");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("ServerFreak.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ChatId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Created")
                        .HasColumnType("longtext");

                    b.Property<bool>("Sent")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("ServerFreak.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("ServerFreak.Models.UserF", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Image")
                        .HasColumnType("longtext");

                    b.Property<string>("NickName")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Server")
                        .HasColumnType("longtext");

                    b.HasKey("Username");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebAppServer1.Models.Contact", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Last")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserFUsername")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("server")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("UserFUsername");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("ServerFreak.Models.Chat", b =>
                {
                    b.HasOne("ServerFreak.Models.UserF", null)
                        .WithMany("Chats")
                        .HasForeignKey("UserFUsername");
                });

            modelBuilder.Entity("ServerFreak.Models.Message", b =>
                {
                    b.HasOne("ServerFreak.Models.Chat", null)
                        .WithMany("Messages")
                        .HasForeignKey("ChatId");
                });

            modelBuilder.Entity("WebAppServer1.Models.Contact", b =>
                {
                    b.HasOne("ServerFreak.Models.UserF", null)
                        .WithMany("Contacts")
                        .HasForeignKey("UserFUsername");
                });

            modelBuilder.Entity("ServerFreak.Models.Chat", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("ServerFreak.Models.UserF", b =>
                {
                    b.Navigation("Chats");

                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
