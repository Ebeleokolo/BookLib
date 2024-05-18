using System.ComponentModel.DataAnnotations;

namespace BookLib.Models.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; } 
        public string Name { get; set; }    
        public List<SubCategory> subCatogories { get; set; } = new List<SubCategory>();
    }
    public class SubCategory
    {
        [Key]
        public int SubCategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CategoryId { get; set; }

        //Nav prop
        public Category category { get; set; } = new Category();
    } 
}
