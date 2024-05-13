﻿namespace BookLib.Models.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Author { get; set; } = "";
        public string Language { get; set; } = "";
        public string ISBN { get; set; } = "";
        public int NumberOfPages { get; set; }
        public string Publisher { get; set; } = "";
        public string PhotoUrl { get; set; } = "";
        public string PublicId { get; set; } = "";
        public string CopiesInLibrary { get; set; } = "";
        public string AddedBy { get; set; } = "";
        public DateOnly PublishedDate { get; set; }
        //Nav property
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Rating> Ratings { get; set; } = new List<Rating>();
    }
}
