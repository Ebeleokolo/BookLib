using Microsoft.AspNetCore.Identity;

namespace BookLib.Models.Entities
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        //nav prop
        public IList<Review> Reviews { get; set; }= new List<Review>();
        public IList<Rating> Ratings { get; set; } = new List<Rating>();

    }
}
