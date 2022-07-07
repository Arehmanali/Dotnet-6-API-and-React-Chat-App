using System.ComponentModel.DataAnnotations.Schema;

namespace ChatApp.Models
{
    public class Users : ApplicationUser
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        [NotMapped]
        public string imageName { get; set; }
        [NotMapped]
        public IFormFile imageFile { get; set; }
        [NotMapped]
        public string imageSource { get; set; }
    }
}
