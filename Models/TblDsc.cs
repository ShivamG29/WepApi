using System;
using System.Collections.Generic;

namespace Dsc_Core_WebAPI_YT.Models;

public partial class TblDsc
{
    public int Id { get; set; }

    public string? CertificateClass { get; set; }

    public string? CertificateTypes { get; set; }

    public string? CertificateValidity { get; set; }

    public string? PanNo { get; set; }

    public string? PersonName { get; set; }

    public string? EmailId { get; set; }

    public string? MobileNo { get; set; }

    public int? Pincode { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Address { get; set; }

    public string? Gender { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? EkycId { get; set; }

    public string? EkycPin { get; set; }

    public int? AadharLast4Digits { get; set; }

    public string? DownloadKey { get; set; }

    public string? AddressProof { get; set; }

    public string? IdProof { get; set; }

    public string? UploadPhoto { get; set; }

    public string? Remark { get; set; }
}
