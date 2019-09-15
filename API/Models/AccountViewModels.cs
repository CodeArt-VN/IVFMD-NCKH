using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    // Models returned by AccountController actions.

    public class ExternalLoginViewModel
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public string State { get; set; }
    }

    public class ManageInfoViewModel
    {
        public string LocalLoginProvider { get; set; }

        public string Email { get; set; }

        public IEnumerable<UserLoginInfoViewModel> Logins { get; set; }

        public IEnumerable<ExternalLoginViewModel> ExternalLoginProviders { get; set; }
    }

    public class UserInfoViewModel
    {
        public string ID { get; set; }

        
        public string UserName { get; set; }
        public List<Role> Roles { get; set; }

        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public string FullName { get; set; }
        public string DOB { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public int StaffID { get; set; }
        public int PatientID { get; set; }
        public int PartnerID { get; set; }

        public string Status { get; set; }
        public bool LockoutEnabled { get; set; }

        public bool Gender { get; set; }
        public string Address { get; set; }
        public Nullable<int> IDTinhThanh { get; set; }
        public Nullable<int> IDQuanHuyen { get; set; }

    }

    public class Role
    {
        public string RoleId { get; set; }
        public string Name { get; set; }
        
    }

    public class UserLoginInfoViewModel
    {
        public string LoginProvider { get; set; }

        public string ProviderKey { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        public string Email { get; set; }
    }

    public class ResetPasswordViewModel
    {
        
        public string userId { get; set; }
        public string token { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu tối thiểu 6 ký tự.")]
        [StringLength(100, ErrorMessage = "Vui lòng nhập mật khẩu tối thiểu 6 ký tự.", MinimumLength =6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Mật khẩu không khớp.")]
        public string ConfirmPassword { get; set; }
    }

}
