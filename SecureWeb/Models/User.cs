using System;
using System.ComponentModel.DataAnnotations;

namespace SecureWeb.Models;

public class User
{
    [Key]
    public string Username { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string Role { get; set; } = null!;

}
