﻿// <auto-generated />
using API.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace API.Migrations
{
    [DbContext(typeof(ApiContext))]
    [Migration("20180921043416_tables")]
    partial class tables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("API.Models.Comment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("comment");

                    b.Property<int>("post_id");

                    b.Property<int>("user_id");

                    b.HasKey("id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("API.Models.Photo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("encoded_photo");

                    b.Property<string>("feed_url");

                    b.Property<float>("latitude");

                    b.Property<string>("location");

                    b.Property<float>("longitude");

                    b.Property<string>("open_graph_url");

                    b.Property<int>("post_id");

                    b.Property<string>("raw_url");

                    b.Property<string>("watermarked_url");

                    b.HasKey("id");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("API.Models.Post", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("in_my_work");

                    b.Property<int>("job_site_id");

                    b.Property<int>("user_id");

                    b.HasKey("id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("API.Models.Reaction", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("post_id");

                    b.Property<string>("type");

                    b.Property<int>("user_id");

                    b.HasKey("id");

                    b.ToTable("Reactions");
                });

            modelBuilder.Entity("API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("birth_year");

                    b.Property<string>("hashed_verification_pin");

                    b.Property<string>("location");

                    b.Property<string>("phone");

                    b.Property<string>("photo_url");

                    b.Property<string>("role");

                    b.Property<string>("status");

                    b.Property<int>("verification_pin_timeout");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}