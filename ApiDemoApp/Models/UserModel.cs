using System.ComponentModel.DataAnnotations;

namespace ApiDemoApp.Models
{
    public class UserModel
    {
        [Required]
        [MinLength(10)]
        public string FirstName { get; set; }
    }
}
