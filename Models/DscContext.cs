using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dsc_Core_WebAPI_YT.Models;

public partial class DscContext : DbContext
{
    public DscContext()
    {
    }

    public DscContext(DbContextOptions<DscContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblDsc> TblDscs { get; set; }

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblDsc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tbl_Dsc__3213E83FBCE86FFB");

            entity.ToTable("Tbl_Dsc");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AadharLast4Digits).HasColumnName("Aadhar_last_4_Digits");
            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AddressProof)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Address_Proof");
            entity.Property(e => e.CertificateClass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Certificate_class");
            entity.Property(e => e.CertificateTypes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Certificate_Types");
            entity.Property(e => e.CertificateValidity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Certificate_Validity");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("date")
                .HasColumnName("Date_of_Birth");
            entity.Property(e => e.DownloadKey)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Download_Key");
            entity.Property(e => e.EkycId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ekyc_Id");
            entity.Property(e => e.EkycPin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ekyc_Pin");
            entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Email_ID");
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdProof)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Id_Proof");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Mobile_No");
            entity.Property(e => e.PanNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Pan_No");
            entity.Property(e => e.PersonName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Person_Name");
            entity.Property(e => e.Remark).IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UploadPhoto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Upload_Photo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
