// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PropertyManagerWeb.Data;

#nullable disable

namespace PropertyManagerWeb.Migrations
{
    [DbContext(typeof(PropertyManagerContext))]
    partial class PropertyManagerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PropertyManagerWeb.Models.Contratos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Deposito")
                        .HasColumnType("decimal(6,2)");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdInquilino")
                        .HasColumnType("int");

                    b.Property<int>("IdPropiedad")
                        .HasColumnType("int");

                    b.Property<int?>("PropiedadId")
                        .HasColumnType("int");

                    b.Property<string>("Terminos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PropiedadId");

                    b.ToTable("Contratos");
                });

            modelBuilder.Entity("PropertyManagerWeb.Models.Inquilinos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdPropiedad")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PropiedadId")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PropiedadId");

                    b.ToTable("Inquilinos");
                });

            modelBuilder.Entity("PropertyManagerWeb.Models.Pagos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ContratoId")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaPago")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdContrato")
                        .HasColumnType("int");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("Id");

                    b.HasIndex("ContratoId");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("PropertyManagerWeb.Models.Propiedades", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Dirección")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Disponible")
                        .HasColumnType("bit");

                    b.Property<int>("NumeroHabitaciones")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioAlquiler")
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("TipoPropiedad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Propiedades");
                });

            modelBuilder.Entity("PropertyManagerWeb.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PropertyManagerWeb.Models.Contratos", b =>
                {
                    b.HasOne("PropertyManagerWeb.Models.Propiedades", "Propiedad")
                        .WithMany()
                        .HasForeignKey("PropiedadId");

                    b.Navigation("Propiedad");
                });

            modelBuilder.Entity("PropertyManagerWeb.Models.Inquilinos", b =>
                {
                    b.HasOne("PropertyManagerWeb.Models.Propiedades", "Propiedad")
                        .WithMany()
                        .HasForeignKey("PropiedadId");

                    b.Navigation("Propiedad");
                });

            modelBuilder.Entity("PropertyManagerWeb.Models.Pagos", b =>
                {
                    b.HasOne("PropertyManagerWeb.Models.Contratos", "Contrato")
                        .WithMany()
                        .HasForeignKey("ContratoId");

                    b.Navigation("Contrato");
                });
#pragma warning restore 612, 618
        }
    }
}
