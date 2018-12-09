﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shipping.Data;

namespace Shipping.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Shipping.Models.Craditcarrd", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("C_Number");

                    b.Property<string>("C_address");

                    b.Property<string>("C_name")
                        .HasMaxLength(14);

                    b.Property<string>("Expirydate")
                        .IsRequired();

                    b.Property<int>("Vcs")
                        .HasMaxLength(3);

                    b.HasKey("ID");

                    b.ToTable("Craditcarrds");
                });

            modelBuilder.Entity("Shipping.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int>("C_ID");

                    b.Property<int?>("CreditcardID");

                    b.Property<decimal>("CustomerNumber")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("E_Mail");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Phone");

                    b.Property<DateTime>("Regist_Date");

                    b.HasKey("Id");

                    b.HasIndex("CreditcardID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Shipping.Models.Items", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.Property<int>("Produces_ID");

                    b.Property<int?>("Produces_ProID");

                    b.Property<int>("Quantity");

                    b.HasKey("ID");

                    b.HasIndex("Produces_ProID");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Shipping.Models.O_I", b =>
                {
                    b.Property<int>("O_ID");

                    b.Property<int>("I_ID");

                    b.HasKey("O_ID", "I_ID");

                    b.HasIndex("I_ID");

                    b.ToTable("O_I");
                });

            modelBuilder.Entity("Shipping.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Price");

                    b.Property<int?>("ProductID");

                    b.Property<string>("Quality")
                        .HasMaxLength(14);

                    b.Property<int>("Shippingcost");

                    b.HasKey("ID");

                    b.HasIndex("ProductID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Shipping.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Model");

                    b.Property<string>("P_Name");

                    b.Property<int>("Quantity");

                    b.HasKey("ID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Shipping.Models.Customer", b =>
                {
                    b.HasOne("Shipping.Models.Craditcarrd", "Creditcard")
                        .WithMany("CustomersLIST")
                        .HasForeignKey("CreditcardID");
                });

            modelBuilder.Entity("Shipping.Models.Items", b =>
                {
                    b.HasOne("Shipping.Models.Product", "Produces_Pro")
                        .WithMany()
                        .HasForeignKey("Produces_ProID");
                });

            modelBuilder.Entity("Shipping.Models.O_I", b =>
                {
                    b.HasOne("Shipping.Models.Items", "Items_Items")
                        .WithMany("Orderlist")
                        .HasForeignKey("I_ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Shipping.Models.Order", "Order_Order")
                        .WithMany("Itemslist")
                        .HasForeignKey("O_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Shipping.Models.Order", b =>
                {
                    b.HasOne("Shipping.Models.Product")
                        .WithMany("OrdersLIST")
                        .HasForeignKey("ProductID");
                });
#pragma warning restore 612, 618
        }
    }
}