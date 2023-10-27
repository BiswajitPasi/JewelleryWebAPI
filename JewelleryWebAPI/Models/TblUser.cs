using JewelleryWebAPI.Tools;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JewelleryWebAPI.Models;


public partial class TblUser
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal UserId { get; set; }

    [EmailAddress(ErrorMessage = Consts.EmailValidationError)]
    [MinLength(Consts.UsernameMinLength, ErrorMessage = Consts.UsernameLengthValidationError)]
    public string? UserName { get; set; }
    [RegularExpression(Consts.PasswordRegex, ErrorMessage = Consts.PasswordValidationError)]
    public string? Password { get; set; }

    public bool? Active { get; set; }

    public decimal? RoleId { get; set; }

    public string? Narration { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? EmployeeId { get; set; }
}
