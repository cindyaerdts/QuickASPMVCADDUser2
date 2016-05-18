using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickASPMVCADDUser2.Models
{
    public class User
    {
        //public User(string username, string firstname, string lastname, string mailAdress)
        //{
        //    UserName = username;
        //    FirstName = firstname;
        //    LastName = lastname;
        //    Mailadress = mailAdress;
        //}
        [Required]
        [StringLength(50)]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Mail Adress")]
        public string Mailadress { get; set; }
    }
}