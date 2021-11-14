﻿// <auto-generated />
using System;
using ILG_Global.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ILG_Global.DataAccess.Migrations
{
    [DbContext(typeof(ILG_GlobalContext))]
    [Migration("20211114151908_yy")]
    partial class yy
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ILG_Global.BussinessLogic.Models.ContactInformationDetail", b =>
                {
                    b.Property<int>("ContactInformationID")
                        .HasColumnType("int");

                    b.Property<string>("LanguageCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactInformationID", "LanguageCode");

                    b.HasIndex("LanguageCode");

                    b.ToTable("ContactInformationDetails");
                });

            modelBuilder.Entity("ILG_Global.BussinessLogic.Models.ContactInformationMaster", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FontAwsomeIconCssClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("ContactInformationMasters");
                });

            modelBuilder.Entity("ILG_Global.BussinessLogic.Models.HtmlContentDetail", b =>
                {
                    b.Property<int>("HtmlContentID")
                        .HasColumnType("int");

                    b.Property<string>("LanguageCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HtmlContentID", "LanguageCode");

                    b.HasIndex("LanguageCode");

                    b.ToTable("HtmlContentDetails");
                });

            modelBuilder.Entity("ILG_Global.BussinessLogic.Models.HtmlContentMaster", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CanBeDeletedByUser")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("HtmlContentMasters");
                });

            modelBuilder.Entity("ILG_Global.BussinessLogic.Models.ImageDetail", b =>
                {
                    b.Property<int>("ImageID")
                        .HasColumnType("int");

                    b.Property<string>("LanguageCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AlternateText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OurServiceMasterID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageID", "LanguageCode");

                    b.HasIndex("LanguageCode");

                    b.HasIndex("OurServiceMasterID");

                    b.ToTable("ImageDetails");
                });

            modelBuilder.Entity("ILG_Global.BussinessLogic.Models.ImageMaster", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int?>("HtmlContentMasterID")
                        .HasColumnType("int");

                    b.Property<int?>("ImageMastersId")
                        .HasColumnType("int");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OurServiceMasterID")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("HtmlContentMasterID");

                    b.HasIndex("ImageMastersId");

                    b.HasIndex("OurServiceMasterID");

                    b.ToTable("ImageMasters");
                });

            modelBuilder.Entity("ILG_Global.BussinessLogic.Models.Language", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Code");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("ILG_Global.BussinessLogic.Models.NewsLetterSubscribe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("PreferredLanguage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("NewsLetterSubscribes");
                });

            modelBuilder.Entity("ILG_Global.BussinessLogic.Models.OurServiceDetail", b =>
                {
                    b.Property<int>("OurServiceID")
                        .HasColumnType("int");

                    b.Property<string>("LanguageCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OurServiceID", "LanguageCode");

                    b.HasIndex("LanguageCode");

                    b.ToTable("OurServiceDetails");
                });

            modelBuilder.Entity("ILG_Global.BussinessLogic.Models.OurServiceMaster", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ImageMastersId")
                        .HasColumnType("int");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("OurServiceMasters");
                });

            modelBuilder.Entity("ILG_Global.BussinessLogic.Models.SucessStoryDetail", b =>
                {
                    b.Property<int>("SucessStoryID")
                        .HasColumnType("int");

                    b.Property<string>("LanguageCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SucessStoryID", "LanguageCode");

                    b.HasIndex("LanguageCode");

                    b.ToTable("SucessStoryDetails");
                });

            modelBuilder.Entity("ILG_Global.BussinessLogic.Models.SucessStoryMaster", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("PDF_FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("SucessStoryMasters");
                });

            modelBuilder.Entity("ILG_Global.BussinessLogic.Models.ContactInformationDetail", b =>
                {
                    b.HasOne("ILG_Global.BussinessLogic.Models.ContactInformationMaster", "ContactInformationMaster")
                        .WithMany("ContactInformationDetails")
                        .HasForeignKey("ContactInformationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ILG_Global.BussinessLogic.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ContactInformationMaster");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("ILG_Global.BussinessLogic.Models.HtmlContentDetail", b =>
                {
                    b.HasOne("ILG_Global.BussinessLogic.Models.HtmlContentMaster", "HtmlContentMaster")
                        .WithMany("HtmlContentDetails")
                        .HasForeignKey("HtmlContentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ILG_Global.BussinessLogic.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HtmlContentMaster");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("ILG_Global.BussinessLogic.Models.ImageDetail", b =>
                {
                    b.HasOne("ILG_Global.BussinessLogic.Models.ImageMaster", "ImageMaster")
                        .WithMany("ImageDetails")
                        .HasForeignKey("ImageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ILG_Global.BussinessLogic.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ILG_Global.BussinessLogic.Models.OurServiceMaster", "OurServiceMaster")
                        .WithMany("ImageDetails")
                        .HasForeignKey("OurServiceMasterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ImageMaster");

                    b.Navigation("Language");

                    b.Navigation("OurServiceMaster");
                });

            modelBuilder.Entity("ILG_Global.BussinessLogic.Models.ImageMaster", b =>
                {
                    b.HasOne("ILG_Global.BussinessLogic.Models.HtmlContentMaster", null)
                        .WithMany("ImageMasters")
                        .HasForeignKey("HtmlContentMasterID");

                    b.HasOne("ILG_Global.BussinessLogic.Models.OurServiceMaster", null)
                        .WithMany("ImageMasters")
                        .HasForeignKey("ImageMastersId");

                    b.HasOne("ILG_Global.BussinessLogic.Models.OurServiceMaster", "OurServiceMaster")
                        .WithMany()
                        .HasForeignKey("OurServiceMasterID");

                    b.Navigation("OurServiceMaster");
                });

            modelBuilder.Entity("ILG_Global.BussinessLogic.Models.OurServiceDetail", b =>
                {
                    b.HasOne("ILG_Global.BussinessLogic.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ILG_Global.BussinessLogic.Models.OurServiceMaster", "OurServiceMaster")
                        .WithMany("OurServiceDetails")
                        .HasForeignKey("OurServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");

                    b.Navigation("OurServiceMaster");
                });

            modelBuilder.Entity("ILG_Global.BussinessLogic.Models.SucessStoryDetail", b =>
                {
                    b.HasOne("ILG_Global.BussinessLogic.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ILG_Global.BussinessLogic.Models.SucessStoryMaster", "SucessStoryMaster")
                        .WithMany()
                        .HasForeignKey("SucessStoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");

                    b.Navigation("SucessStoryMaster");
                });

            modelBuilder.Entity("ILG_Global.BussinessLogic.Models.ContactInformationMaster", b =>
                {
                    b.Navigation("ContactInformationDetails");
                });

            modelBuilder.Entity("ILG_Global.BussinessLogic.Models.HtmlContentMaster", b =>
                {
                    b.Navigation("HtmlContentDetails");

                    b.Navigation("ImageMasters");
                });

            modelBuilder.Entity("ILG_Global.BussinessLogic.Models.ImageMaster", b =>
                {
                    b.Navigation("ImageDetails");
                });

            modelBuilder.Entity("ILG_Global.BussinessLogic.Models.OurServiceMaster", b =>
                {
                    b.Navigation("ImageDetails");

                    b.Navigation("ImageMasters");

                    b.Navigation("OurServiceDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
