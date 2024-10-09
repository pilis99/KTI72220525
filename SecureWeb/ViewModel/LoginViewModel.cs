using System;
using System.ComponentModel.DataAnnotations;

namespace SecureWeb.ViewModel;

public class LoginViewModel
{
    [Required]
    public string Username { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;
    public bool RememberMe { get; set; }
    public string ReturnUrl { get; set; } = string.Empty;

}
