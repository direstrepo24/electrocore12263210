﻿// <auto-generated />
using Electro.model.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Electrocore.Migrations
{
    [DbContext(typeof(MyAppContext))]
    partial class MyAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("Electro.model.datatakemodel.Cable", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.Property<string>("Sigla");

                    b.HasKey("Id");

                    b.ToTable("Cable");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.Ciudad", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.Property<long>("departmentoId");

                    b.HasKey("Id");

                    b.HasIndex("departmentoId");

                    b.ToTable("Ciudad");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.Departamento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.Property<long>("codigodpto");

                    b.HasKey("Id");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.DetalleTipoCable", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("Cable_Id");

                    b.Property<long>("Tipocable_Id");

                    b.HasKey("Id");

                    b.HasIndex("Cable_Id");

                    b.HasIndex("Tipocable_Id");

                    b.ToTable("DetalleTipoCable");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.DetalleTipoNovedad", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<string>("Nombre");

                    b.Property<long>("Tipo_Novedad_id");

                    b.HasKey("Id");

                    b.HasIndex("Tipo_Novedad_id");

                    b.ToTable("DetalleTipoNovedad");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.Dispositivo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Android_Id");

                    b.Property<string>("Android_Version");

                    b.Property<string>("Device_Name");

                    b.Property<string>("Direccion_Ip");

                    b.Property<bool>("Estado");

                    b.Property<string>("Imei");

                    b.Property<string>("Local_Ip_Address");

                    b.Property<string>("MacAddr");

                    b.Property<string>("Phone_Type_Device");

                    b.Property<string>("Software_Version");

                    b.Property<long?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Dispositivo");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.Elemento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AlturaDisponible");

                    b.Property<long>("Ciudad_Id");

                    b.Property<string>("CodigoApoyo");

                    b.Property<long>("Estado_id");

                    b.Property<DateTime>("FechaLevantamiento");

                    b.Property<DateTime?>("Fecha_Sincronizacion");

                    b.Property<string>("HoraFin");

                    b.Property<string>("HoraInicio");

                    b.Property<string>("Hora_Sincronizacion");

                    b.Property<string>("Imei_Device");

                    b.Property<long>("Longitud_Elemento_Id");

                    b.Property<long>("Material_Id");

                    b.Property<long>("Nivel_Tension_Id");

                    b.Property<long>("NumeroApoyo");

                    b.Property<long>("Proyecto_Id");

                    b.Property<string>("ResistenciaMecanica");

                    b.Property<long>("Retenidas");

                    b.Property<string>("Token_Elemento");

                    b.Property<long>("Usuario_Id");

                    b.HasKey("Id");

                    b.HasIndex("Ciudad_Id");

                    b.HasIndex("Estado_id");

                    b.HasIndex("Longitud_Elemento_Id");

                    b.HasIndex("Material_Id");

                    b.HasIndex("Nivel_Tension_Id");

                    b.HasIndex("Proyecto_Id");

                    b.ToTable("Elemento");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.ElementoCable", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("Cantidad");

                    b.Property<long?>("Ciudad_Empresa_Id");

                    b.Property<long>("Ciudad_Id");

                    b.Property<string>("Codigo");

                    b.Property<long>("DetalleTipocable_Id");

                    b.Property<long>("Elemento_Id");

                    b.Property<long>("Empresa_Id");

                    b.Property<bool>("SobreRbt");

                    b.Property<bool>("Tiene_Marquilla");

                    b.HasKey("Id");

                    b.HasIndex("Ciudad_Empresa_Id");

                    b.HasIndex("DetalleTipocable_Id");

                    b.HasIndex("Elemento_Id");

                    b.ToTable("ElementoCable");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.Empresa", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<string>("Direccion");

                    b.Property<bool>("Is_Operadora");

                    b.Property<string>("Nit");

                    b.Property<string>("Nombre");

                    b.Property<string>("Telefono");

                    b.HasKey("Id");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.EquipoElemento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("Cantidad");

                    b.Property<long?>("Ciudad_Empresa_Id");

                    b.Property<long>("Ciudad_Id");

                    b.Property<string>("Codigo");

                    b.Property<bool>("ConectadoRbt");

                    b.Property<long>("Consumo");

                    b.Property<string>("Descripcion");

                    b.Property<long>("Elemento_Id");

                    b.Property<long>("EmpresaId");

                    b.Property<bool>("MedidorBt");

                    b.Property<long>("TipoEquipo_Id");

                    b.Property<string>("UnidadMedida");

                    b.HasKey("Id");

                    b.HasIndex("Ciudad_Empresa_Id");

                    b.HasIndex("Elemento_Id");

                    b.HasIndex("TipoEquipo_Id");

                    b.ToTable("EquipoElemento");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.Estado", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.Property<string>("Sigla");

                    b.HasKey("Id");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.Foto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<long>("Elemento_Id");

                    b.Property<DateTime>("FechaCreacion");

                    b.Property<string>("Hora");

                    b.Property<long?>("NovedadId");

                    b.Property<long?>("Novedad_Id");

                    b.Property<string>("Ruta");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.HasIndex("Elemento_Id");

                    b.HasIndex("NovedadId");

                    b.ToTable("Foto");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.LocalizacionCable", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Altitud");

                    b.Property<string>("Color");

                    b.Property<long>("ElementoCable_Id");

                    b.Property<string>("LineaCable");

                    b.HasKey("Id");

                    b.HasIndex("ElementoCable_Id");

                    b.ToTable("Project_locationcable");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.LocalizacionElemento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Barrio");

                    b.Property<string>("Coordenadas");

                    b.Property<string>("Direccion");

                    b.Property<string>("DireccionAproximadaGps");

                    b.Property<long>("Element_Id");

                    b.Property<decimal>("Latitud");

                    b.Property<string>("Localidad");

                    b.Property<decimal>("Longitud");

                    b.Property<string>("ReferenciaLocalizacion");

                    b.Property<string>("Sector");

                    b.HasKey("Id");

                    b.HasIndex("Element_Id");

                    b.ToTable("Project_locationelement");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.LongitudElemento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UnidadMedida");

                    b.Property<double>("Valor");

                    b.HasKey("Id");

                    b.ToTable("LongitudElemento");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.Material", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.Property<string>("Sigla");

                    b.HasKey("Id");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.NivelTensionElemento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.Property<string>("Sigla");

                    b.Property<long>("Valor");

                    b.HasKey("Id");

                    b.ToTable("NivelTensionElemento");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.Novedad", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<long>("Detalle_Tipo_Novedad_Id");

                    b.Property<long>("Elemento_Id");

                    b.HasKey("Id");

                    b.HasIndex("Detalle_Tipo_Novedad_Id");

                    b.HasIndex("Elemento_Id");

                    b.ToTable("Novedad");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.Perdida", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("Cantidad");

                    b.Property<string>("Concepto");

                    b.Property<string>("Descripcion");

                    b.Property<long>("Elemento_Id");

                    b.Property<bool>("Response_Checked");

                    b.Property<long>("Tipo_Perdida_Id");

                    b.Property<double>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("Elemento_Id");

                    b.HasIndex("Tipo_Perdida_Id");

                    b.ToTable("Perdida");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.Proyecto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("Ciudad_Id");

                    b.Property<string>("Descripcion");

                    b.Property<DateTime>("FechaFin");

                    b.Property<DateTime>("FechaInicio");

                    b.Property<bool>("IsActivo");

                    b.Property<string>("Nombre");

                    b.Property<string>("OrdenTrabajo");

                    b.HasKey("Id");

                    b.HasIndex("Ciudad_Id");

                    b.ToTable("Proyecto");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.Proyecto_Empresa", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("Empresa_Id");

                    b.Property<bool>("IsInterventora");

                    b.Property<bool>("IsOperadora");

                    b.Property<bool>("IsPropietaria");

                    b.Property<long>("Proyecto_Id");

                    b.HasKey("Id");

                    b.HasIndex("Empresa_Id");

                    b.HasIndex("Proyecto_Id");

                    b.ToTable("Proyecto_Empresa");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.ProyectoUsuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsActivo");

                    b.Property<long>("Proyecto_Id");

                    b.Property<long>("Usuario_Id");

                    b.HasKey("Id");

                    b.HasIndex("Proyecto_Id");

                    b.HasIndex("Usuario_Id");

                    b.ToTable("ProyectoUsuario");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.Tipo_Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Tipo_Usuario");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.TipoCable", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("TipoCable");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.TipoEquipo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("TipoEquipo");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.TipoNovedad", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("TipoNovedad");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.Usuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<string>("Cedula");

                    b.Property<string>("CorreoElectronico");

                    b.Property<string>("Direccion");

                    b.Property<long>("Empresa_Id");

                    b.Property<string>("Nombre");

                    b.Property<string>("Passsword");

                    b.Property<string>("Telefono");

                    b.Property<int>("Tipo_Usuario_Id");

                    b.HasKey("Id");

                    b.HasIndex("Empresa_Id");

                    b.HasIndex("Tipo_Usuario_Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Electro.model.Models.datatakemodel.Ciudad_Empresa", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("Ciudad_Id");

                    b.Property<long>("Empresa_Id");

                    b.HasKey("Id");

                    b.HasIndex("Ciudad_Id");

                    b.HasIndex("Empresa_Id");

                    b.ToTable("Ciudad_Empresa");
                });

            modelBuilder.Entity("Electro.model.Models.datatakemodel.Tipo_Perdida", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Tipo_Perdida");
                });

            modelBuilder.Entity("OpenIddict.Models.OpenIddictApplication", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientId")
                        .IsRequired();

                    b.Property<string>("ClientSecret");

                    b.Property<string>("DisplayName");

                    b.Property<string>("PostLogoutRedirectUris");

                    b.Property<string>("RedirectUris");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("OpenIddictApplications");
                });

            modelBuilder.Entity("OpenIddict.Models.OpenIddictAuthorization", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationId");

                    b.Property<string>("Scopes");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<string>("Subject")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.ToTable("OpenIddictAuthorizations");
                });

            modelBuilder.Entity("OpenIddict.Models.OpenIddictScope", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("OpenIddictScopes");
                });

            modelBuilder.Entity("OpenIddict.Models.OpenIddictToken", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationId");

                    b.Property<string>("AuthorizationId");

                    b.Property<string>("Ciphertext");

                    b.Property<DateTimeOffset?>("CreationDate");

                    b.Property<DateTimeOffset?>("ExpirationDate");

                    b.Property<string>("Hash");

                    b.Property<string>("Status");

                    b.Property<string>("Subject")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("AuthorizationId");

                    b.HasIndex("Hash")
                        .IsUnique();

                    b.ToTable("OpenIddictTokens");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.Ciudad", b =>
                {
                    b.HasOne("Electro.model.datatakemodel.Departamento", "departmento")
                        .WithMany("ciudades")
                        .HasForeignKey("departmentoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Electro.model.datatakemodel.DetalleTipoCable", b =>
                {
                    b.HasOne("Electro.model.datatakemodel.Cable", "Cable")
                        .WithMany("DetalleTipoCables")
                        .HasForeignKey("Cable_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Electro.model.datatakemodel.TipoCable", "TipoCable")
                        .WithMany("DetalleTipoCables")
                        .HasForeignKey("Tipocable_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Electro.model.datatakemodel.DetalleTipoNovedad", b =>
                {
                    b.HasOne("Electro.model.datatakemodel.TipoNovedad", "TipoNovedad")
                        .WithMany("DetalleTipoNovedades")
                        .HasForeignKey("Tipo_Novedad_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Electro.model.datatakemodel.Dispositivo", b =>
                {
                    b.HasOne("Electro.model.datatakemodel.Usuario", "Usuario")
                        .WithMany("Dispositivos")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.Elemento", b =>
                {
                    b.HasOne("Electro.model.datatakemodel.Ciudad", "Ciudad")
                        .WithMany("Elementos")
                        .HasForeignKey("Ciudad_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Electro.model.datatakemodel.Estado", "Estado")
                        .WithMany("Elementos")
                        .HasForeignKey("Estado_id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Electro.model.datatakemodel.LongitudElemento", "LongitudElemento")
                        .WithMany("Elementos")
                        .HasForeignKey("Longitud_Elemento_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Electro.model.datatakemodel.Material", "Material")
                        .WithMany("Elementos")
                        .HasForeignKey("Material_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Electro.model.datatakemodel.NivelTensionElemento", "NivelTensionElemento")
                        .WithMany("Elemento")
                        .HasForeignKey("Nivel_Tension_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Electro.model.datatakemodel.Proyecto", "Proyecto")
                        .WithMany("Elementos")
                        .HasForeignKey("Proyecto_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Electro.model.datatakemodel.ElementoCable", b =>
                {
                    b.HasOne("Electro.model.Models.datatakemodel.Ciudad_Empresa", "Ciudad_Empresa")
                        .WithMany("ElementoCables")
                        .HasForeignKey("Ciudad_Empresa_Id");

                    b.HasOne("Electro.model.datatakemodel.DetalleTipoCable", "DetalleTipoCable")
                        .WithMany("ElementoCable")
                        .HasForeignKey("DetalleTipocable_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Electro.model.datatakemodel.Elemento", "Elemento")
                        .WithMany("Cables")
                        .HasForeignKey("Elemento_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Electro.model.datatakemodel.EquipoElemento", b =>
                {
                    b.HasOne("Electro.model.Models.datatakemodel.Ciudad_Empresa", "Ciudad_Empresa")
                        .WithMany("EquipoElementos")
                        .HasForeignKey("Ciudad_Empresa_Id");

                    b.HasOne("Electro.model.datatakemodel.Elemento", "Elemento")
                        .WithMany("Equipos")
                        .HasForeignKey("Elemento_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Electro.model.datatakemodel.TipoEquipo", "TipoEquipo")
                        .WithMany("EquipoElemento")
                        .HasForeignKey("TipoEquipo_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Electro.model.datatakemodel.Foto", b =>
                {
                    b.HasOne("Electro.model.datatakemodel.Elemento", "Elemento")
                        .WithMany("Fotos")
                        .HasForeignKey("Elemento_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Electro.model.datatakemodel.Novedad", "Novedad")
                        .WithMany("Fotos")
                        .HasForeignKey("NovedadId");
                });

            modelBuilder.Entity("Electro.model.datatakemodel.LocalizacionCable", b =>
                {
                    b.HasOne("Electro.model.datatakemodel.ElementoCable", "ElementoCable")
                        .WithMany("LocalizacionCables")
                        .HasForeignKey("ElementoCable_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Electro.model.datatakemodel.LocalizacionElemento", b =>
                {
                    b.HasOne("Electro.model.datatakemodel.Elemento", "Elemento")
                        .WithMany("LocalizacionElementos")
                        .HasForeignKey("Element_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Electro.model.datatakemodel.Novedad", b =>
                {
                    b.HasOne("Electro.model.datatakemodel.DetalleTipoNovedad", "DetalleTipoNovedad")
                        .WithMany("Novedades")
                        .HasForeignKey("Detalle_Tipo_Novedad_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Electro.model.datatakemodel.Elemento", "Elemento")
                        .WithMany("Novedades")
                        .HasForeignKey("Elemento_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Electro.model.datatakemodel.Perdida", b =>
                {
                    b.HasOne("Electro.model.datatakemodel.Elemento", "Elemento")
                        .WithMany("Perdidas")
                        .HasForeignKey("Elemento_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Electro.model.Models.datatakemodel.Tipo_Perdida", "Tipo_Perdida")
                        .WithMany("Perdidas")
                        .HasForeignKey("Tipo_Perdida_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Electro.model.datatakemodel.Proyecto", b =>
                {
                    b.HasOne("Electro.model.datatakemodel.Ciudad", "Ciudad")
                        .WithMany("proyecto")
                        .HasForeignKey("Ciudad_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Electro.model.datatakemodel.Proyecto_Empresa", b =>
                {
                    b.HasOne("Electro.model.datatakemodel.Empresa", "Empresa")
                        .WithMany("ProyectoEmpresas")
                        .HasForeignKey("Empresa_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Electro.model.datatakemodel.Proyecto", "Proyecto")
                        .WithMany("Proyecto_Empresas")
                        .HasForeignKey("Proyecto_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Electro.model.datatakemodel.ProyectoUsuario", b =>
                {
                    b.HasOne("Electro.model.datatakemodel.Proyecto", "proyecto")
                        .WithMany("ProyectoUsuarios")
                        .HasForeignKey("Proyecto_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Electro.model.datatakemodel.Usuario", "Usuario")
                        .WithMany("ProyectoUsuarios")
                        .HasForeignKey("Usuario_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Electro.model.datatakemodel.Usuario", b =>
                {
                    b.HasOne("Electro.model.datatakemodel.Empresa", "Empresa")
                        .WithMany("Usuarios")
                        .HasForeignKey("Empresa_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Electro.model.datatakemodel.Tipo_Usuario", "Tipo_Usuario")
                        .WithMany("Usuarios")
                        .HasForeignKey("Tipo_Usuario_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Electro.model.Models.datatakemodel.Ciudad_Empresa", b =>
                {
                    b.HasOne("Electro.model.datatakemodel.Ciudad", "Ciudad")
                        .WithMany("Ciudad_Empresas")
                        .HasForeignKey("Ciudad_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Electro.model.datatakemodel.Empresa", "Empresa")
                        .WithMany("Ciudad_Empresas")
                        .HasForeignKey("Empresa_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OpenIddict.Models.OpenIddictAuthorization", b =>
                {
                    b.HasOne("OpenIddict.Models.OpenIddictApplication", "Application")
                        .WithMany("Authorizations")
                        .HasForeignKey("ApplicationId");
                });

            modelBuilder.Entity("OpenIddict.Models.OpenIddictToken", b =>
                {
                    b.HasOne("OpenIddict.Models.OpenIddictApplication", "Application")
                        .WithMany("Tokens")
                        .HasForeignKey("ApplicationId");

                    b.HasOne("OpenIddict.Models.OpenIddictAuthorization", "Authorization")
                        .WithMany("Tokens")
                        .HasForeignKey("AuthorizationId");
                });
#pragma warning restore 612, 618
        }
    }
}
