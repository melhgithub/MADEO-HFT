﻿// <auto-generated />
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240831031555_maintitletechnology")]
    partial class maintitletechnology
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Concrete.Admin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Banner", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Banner1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Banner2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Banner3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Banners");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Buynow", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Resim1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("BuyNow");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Footer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Footer");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Form", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.ToTable("Form");
                });

            modelBuilder.Entity("EntityLayer.Concrete.HomePage", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Image1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("HomePage");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Image", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Link", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("GeneralStatus")
                        .HasColumnType("int");

                    b.Property<string>("Gmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GmailStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Linkedin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LinkedinStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Telegram")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TelegramStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Tiktok")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TiktokStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Whatsapp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("WhatsappStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Youtube")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("YoutubeStatus")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Links");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slider1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slider2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slider3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slider4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slider5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Video1")
                        .HasColumnType("bit");

                    b.Property<string>("Video1Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video1Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video1Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Video2")
                        .HasColumnType("bit");

                    b.Property<string>("Video2Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video2Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video2Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Video3")
                        .HasColumnType("bit");

                    b.Property<string>("Video3Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video3Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video3Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Video4")
                        .HasColumnType("bit");

                    b.Property<string>("Video4Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video4Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video4Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Video5")
                        .HasColumnType("bit");

                    b.Property<string>("Video5Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video5Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video5Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Technology1", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Banner1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Banner2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Banner3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Technology1");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Technology2", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Banner1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Banner2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Banner3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Technology2");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Technology3", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Banner1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Banner2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Banner3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Technology3");
                });
#pragma warning restore 612, 618
        }
    }
}
