﻿// <auto-generated />
using MessagesServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MessagesServer.Solution.Migrations
{
    [DbContext(typeof(MessagesServerContext))]
    [Migration("20190820170024_changeusername")]
    partial class changeusername
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MessagesServer.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MessageNote");

                    b.Property<string>("MessageText");

                    b.Property<int>("MessagerNumber");

                    b.Property<string>("UserName");

                    b.HasKey("MessageId");

                    b.ToTable("messages");
                });
#pragma warning restore 612, 618
        }
    }
}
