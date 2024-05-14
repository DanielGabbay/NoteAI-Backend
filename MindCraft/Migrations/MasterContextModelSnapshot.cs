﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MindCraft.Data.Contexts;

#nullable disable

namespace MindCraft.Migrations
{
    [DbContext(typeof(MasterContext))]
    partial class MasterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MindCraft.Data.Entities.File", b =>
                {
                    b.Property<int>("FileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FileId"));

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("FileData")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NoteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UploadDate")
                        .HasColumnType("datetime2");

                    b.HasKey("FileId");

                    b.HasIndex("NoteId");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("MindCraft.Data.Entities.FileAttachment", b =>
                {
                    b.Property<int>("FileAttachmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FileAttachmentId"));

                    b.Property<byte[]>("FileData")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("FileId")
                        .HasColumnType("int");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoteId")
                        .HasColumnType("int");

                    b.HasKey("FileAttachmentId");

                    b.HasIndex("FileId");

                    b.HasIndex("NoteId");

                    b.ToTable("FileAttachments");
                });

            modelBuilder.Entity("MindCraft.Data.Entities.Note", b =>
                {
                    b.Property<int>("NoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoteId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NoteId1")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("NoteId");

                    b.HasIndex("NoteId1");

                    b.HasIndex("UserId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("MindCraft.Data.Entities.NoteLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Action")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoteId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NoteId");

                    b.ToTable("NoteLog");
                });

            modelBuilder.Entity("MindCraft.Data.Entities.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagId"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("TagId");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("Tags");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Tag");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("MindCraft.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RefreshTokenExpiryTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MindCraft.Data.Entities.UsersGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UsersGroups");
                });

            modelBuilder.Entity("NoteTag", b =>
                {
                    b.Property<int>("NoteId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("NoteId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("NoteTag");
                });

            modelBuilder.Entity("UserGroup", b =>
                {
                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("GroupId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserGroup");
                });

            modelBuilder.Entity("MindCraft.Data.Entities.GroupTag", b =>
                {
                    b.HasBaseType("MindCraft.Data.Entities.Tag");

                    b.HasDiscriminator().HasValue("GroupTag");
                });

            modelBuilder.Entity("MindCraft.Data.Entities.SystemTag", b =>
                {
                    b.HasBaseType("MindCraft.Data.Entities.Tag");

                    b.HasDiscriminator().HasValue("SystemTag");
                });

            modelBuilder.Entity("MindCraft.Data.Entities.UserTag", b =>
                {
                    b.HasBaseType("MindCraft.Data.Entities.Tag");

                    b.HasDiscriminator().HasValue("UserTag");
                });

            modelBuilder.Entity("MindCraft.Data.Entities.File", b =>
                {
                    b.HasOne("MindCraft.Data.Entities.Note", "Note")
                        .WithMany()
                        .HasForeignKey("NoteId");

                    b.Navigation("Note");
                });

            modelBuilder.Entity("MindCraft.Data.Entities.FileAttachment", b =>
                {
                    b.HasOne("MindCraft.Data.Entities.File", "File")
                        .WithMany()
                        .HasForeignKey("FileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MindCraft.Data.Entities.Note", "Note")
                        .WithMany("Attachments")
                        .HasForeignKey("NoteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("File");

                    b.Navigation("Note");
                });

            modelBuilder.Entity("MindCraft.Data.Entities.Note", b =>
                {
                    b.HasOne("MindCraft.Data.Entities.Note", null)
                        .WithMany("RelatedNotes")
                        .HasForeignKey("NoteId1");

                    b.HasOne("MindCraft.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MindCraft.Data.Entities.NoteLog", b =>
                {
                    b.HasOne("MindCraft.Data.Entities.Note", "Note")
                        .WithMany("Logs")
                        .HasForeignKey("NoteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Note");
                });

            modelBuilder.Entity("MindCraft.Data.Entities.Tag", b =>
                {
                    b.HasOne("MindCraft.Data.Entities.UsersGroup", "Group")
                        .WithMany("Tags")
                        .HasForeignKey("GroupId");

                    b.HasOne("MindCraft.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NoteTag", b =>
                {
                    b.HasOne("MindCraft.Data.Entities.Note", null)
                        .WithMany()
                        .HasForeignKey("NoteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MindCraft.Data.Entities.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UserGroup", b =>
                {
                    b.HasOne("MindCraft.Data.Entities.UsersGroup", null)
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MindCraft.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MindCraft.Data.Entities.Note", b =>
                {
                    b.Navigation("Attachments");

                    b.Navigation("Logs");

                    b.Navigation("RelatedNotes");
                });

            modelBuilder.Entity("MindCraft.Data.Entities.UsersGroup", b =>
                {
                    b.Navigation("Tags");
                });
#pragma warning restore 612, 618
        }
    }
}