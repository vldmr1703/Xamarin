using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Classes
{
    public class BeerDto
    {
        public int Id { get; set; }
        public String ImageUrl { get; set; }
        public String Tagline { get; set; }
        public String Year { get; set; }
        public String Description { get; set; }
        public String Abv { get; set; }
        public String Name { get; set; }

        public BeerDto(int id, String name, String imageUrl, String tagline, String year, String description, String abv)
        {
            Id = id;
            Name = name;
            ImageUrl = imageUrl;
            Tagline = tagline;
            Year = year;
            Description = description;
            Abv = abv;
        }
    }
}
