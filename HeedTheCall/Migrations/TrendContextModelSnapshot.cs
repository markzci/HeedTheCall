﻿// <auto-generated />
using System;
using HeedTheCall.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HeedTheCall.Migrations
{
    [DbContext(typeof(TrendContext))]
    partial class TrendContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HeedTheCall.Entity.Trend", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("PromotedContent")
                        .HasColumnName("promoted_content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Query")
                        .HasColumnName("query")
                        .HasColumnType("bigint");

                    b.Property<long?>("TweetVolume")
                        .HasColumnName("tweet_volume")
                        .HasColumnType("bigint");

                    b.Property<string>("Url")
                        .HasColumnName("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Trends");
                });
#pragma warning restore 612, 618
        }
    }
}
