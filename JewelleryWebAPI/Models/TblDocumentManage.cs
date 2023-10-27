using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JewelleryWebAPI.Models;

public partial class TblDocumentManage
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Srno { get; set; }

    public int? ProductId { get; set; }

    public string? MobileNo { get; set; }

    public string? DocName { get; set; }

    public string? FileName { get; set; }

    public DateTime? UploadDt { get; set; }

    public string? UploadBy { get; set; }
    
    public DateTime? DeleteDt { get; set; }

    public string? DeleteBy { get; set; }

    public string? Status { get; set; }
    [NotMapped]
    public IFormFile? files { get; set; }
}
