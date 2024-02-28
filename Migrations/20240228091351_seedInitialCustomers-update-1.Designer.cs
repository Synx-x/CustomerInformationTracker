﻿// <auto-generated />
using CustomerInformationTracker.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CustomerInformationTracker.Migrations
{
    [DbContext(typeof(CustomerDBContext))]
    [Migration("20240228091351_seedInitialCustomers-update-1")]
    partial class seedInitialCustomersupdate1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CustomerInformationTracker.Infrastructure.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ContactPersonEmailAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ContactPersonName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TelephoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("VATNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Address = "1 Main Rd, Johannesburg",
                            ContactPersonEmailAddress = "sipho@arksoft.co.za",
                            ContactPersonName = "Contact Sipho",
                            Name = "Sipho",
                            TelephoneNumber = "(+27) 67 101 0001",
                            VATNumber = "VAT001"
                        },
                        new
                        {
                            Id = -2,
                            Address = "2 Main Rd, Cape Town",
                            ContactPersonEmailAddress = "thabo@arksoft.co.za",
                            ContactPersonName = "Contact Thabo",
                            Name = "Thabo",
                            TelephoneNumber = "(+27) 67 102 0002",
                            VATNumber = "VAT002"
                        },
                        new
                        {
                            Id = -3,
                            Address = "3 Main Rd, Durban",
                            ContactPersonEmailAddress = "naledi@arksoft.co.za",
                            ContactPersonName = "Contact Naledi",
                            Name = "Naledi",
                            TelephoneNumber = "(+27) 67 103 0003",
                            VATNumber = "VAT003"
                        },
                        new
                        {
                            Id = -4,
                            Address = "4 Main Rd, East London",
                            ContactPersonEmailAddress = "lerato@arksoft.co.za",
                            ContactPersonName = "Contact Lerato",
                            Name = "Lerato",
                            TelephoneNumber = "(+27) 67 104 0004",
                            VATNumber = "VAT004"
                        },
                        new
                        {
                            Id = -5,
                            Address = "5 Main Rd, Port Elizabeth",
                            ContactPersonEmailAddress = "tumi@arksoft.co.za",
                            ContactPersonName = "Contact Tumi",
                            Name = "Tumi",
                            TelephoneNumber = "(+27) 67 105 0005",
                            VATNumber = "VAT005"
                        },
                        new
                        {
                            Id = -6,
                            Address = "6 Main Rd, Bloemfontein",
                            ContactPersonEmailAddress = "kagiso@arksoft.co.za",
                            ContactPersonName = "Contact Kagiso",
                            Name = "Kagiso",
                            TelephoneNumber = "(+27) 67 106 0006",
                            VATNumber = "VAT006"
                        },
                        new
                        {
                            Id = -7,
                            Address = "7 Main Rd, Nelspruit",
                            ContactPersonEmailAddress = "mpho@arksoft.co.za",
                            ContactPersonName = "Contact Mpho",
                            Name = "Mpho",
                            TelephoneNumber = "(+27) 67 107 0007",
                            VATNumber = "VAT007"
                        },
                        new
                        {
                            Id = -8,
                            Address = "8 Main Rd, Kimberley",
                            ContactPersonEmailAddress = "amandla@arksoft.co.za",
                            ContactPersonName = "Contact Amandla",
                            Name = "Amandla",
                            TelephoneNumber = "(+27) 67 108 0008",
                            VATNumber = "VAT008"
                        },
                        new
                        {
                            Id = -9,
                            Address = "9 Main Rd, Polokwane",
                            ContactPersonEmailAddress = "siyanda@arksoft.co.za",
                            ContactPersonName = "Contact Siyanda",
                            Name = "Siyanda",
                            TelephoneNumber = "(+27) 67 109 0009",
                            VATNumber = "VAT009"
                        },
                        new
                        {
                            Id = -10,
                            Address = "10 Main Rd, Pietermaritzburg",
                            ContactPersonEmailAddress = "themba@arksoft.co.za",
                            ContactPersonName = "Contact Themba",
                            Name = "Themba",
                            TelephoneNumber = "(+27) 67 110 0010",
                            VATNumber = "VAT0010"
                        },
                        new
                        {
                            Id = -11,
                            Address = "11 Main Rd, Johannesburg",
                            ContactPersonEmailAddress = "nandi@arksoft.co.za",
                            ContactPersonName = "Contact Nandi",
                            Name = "Nandi",
                            TelephoneNumber = "(+27) 67 111 0011",
                            VATNumber = "VAT0011"
                        },
                        new
                        {
                            Id = -12,
                            Address = "12 Main Rd, Cape Town",
                            ContactPersonEmailAddress = "fikile@arksoft.co.za",
                            ContactPersonName = "Contact Fikile",
                            Name = "Fikile",
                            TelephoneNumber = "(+27) 67 112 0012",
                            VATNumber = "VAT0012"
                        },
                        new
                        {
                            Id = -13,
                            Address = "13 Main Rd, Durban",
                            ContactPersonEmailAddress = "ayanda@arksoft.co.za",
                            ContactPersonName = "Contact Ayanda",
                            Name = "Ayanda",
                            TelephoneNumber = "(+27) 67 113 0013",
                            VATNumber = "VAT0013"
                        },
                        new
                        {
                            Id = -14,
                            Address = "14 Main Rd, East London",
                            ContactPersonEmailAddress = "thandiwe@arksoft.co.za",
                            ContactPersonName = "Contact Thandiwe",
                            Name = "Thandiwe",
                            TelephoneNumber = "(+27) 67 114 0014",
                            VATNumber = "VAT0014"
                        },
                        new
                        {
                            Id = -15,
                            Address = "15 Main Rd, Port Elizabeth",
                            ContactPersonEmailAddress = "lindiwe@arksoft.co.za",
                            ContactPersonName = "Contact Lindiwe",
                            Name = "Lindiwe",
                            TelephoneNumber = "(+27) 67 115 0015",
                            VATNumber = "VAT0015"
                        },
                        new
                        {
                            Id = -16,
                            Address = "16 Main Rd, Bloemfontein",
                            ContactPersonEmailAddress = "siya@arksoft.co.za",
                            ContactPersonName = "Contact Siya",
                            Name = "Siya",
                            TelephoneNumber = "(+27) 67 116 0016",
                            VATNumber = "VAT0016"
                        },
                        new
                        {
                            Id = -17,
                            Address = "17 Main Rd, Nelspruit",
                            ContactPersonEmailAddress = "senzo@arksoft.co.za",
                            ContactPersonName = "Contact Senzo",
                            Name = "Senzo",
                            TelephoneNumber = "(+27) 67 117 0017",
                            VATNumber = "VAT0017"
                        },
                        new
                        {
                            Id = -18,
                            Address = "18 Main Rd, Kimberley",
                            ContactPersonEmailAddress = "nomzamo@arksoft.co.za",
                            ContactPersonName = "Contact Nomzamo",
                            Name = "Nomzamo",
                            TelephoneNumber = "(+27) 67 118 0018",
                            VATNumber = "VAT0018"
                        },
                        new
                        {
                            Id = -19,
                            Address = "19 Main Rd, Polokwane",
                            ContactPersonEmailAddress = "bongani@arksoft.co.za",
                            ContactPersonName = "Contact Bongani",
                            Name = "Bongani",
                            TelephoneNumber = "(+27) 67 119 0019",
                            VATNumber = "VAT0019"
                        },
                        new
                        {
                            Id = -20,
                            Address = "20 Main Rd, Pietermaritzburg",
                            ContactPersonEmailAddress = "sibusiso@arksoft.co.za",
                            ContactPersonName = "Contact Sibusiso",
                            Name = "Sibusiso",
                            TelephoneNumber = "(+27) 67 120 0020",
                            VATNumber = "VAT0020"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
