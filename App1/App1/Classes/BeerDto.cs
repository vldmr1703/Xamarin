using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App1.Classes
{
    public class BeerDto 
        //: INotifyPropertyChanged
    {
        private int id;
        private String imageUrl;
        private String tagline;
        private String year;
        private String description;
        private String abv;
        private String name;
        public int Id {
            get
            { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    //OnPropertyChanged("Id");
                }
            }
        }
        public String ImageUrl
        {
            get
            { return imageUrl; }
            set
            {
                if (imageUrl != value)
                {
                    imageUrl = value;
                    //OnPropertyChanged("ImageUrl");
                }
            }
        }
        public String Tagline
        {
            get
            { return tagline; }
            set
            {
                if (tagline != value)
                {
                    tagline = value;
                    //OnPropertyChanged("Tagline");
                }
            }
        }
        public String Year
        {
            get
            { return year; }
            set
            {
                if (year != value)
                {
                    year = value;
                    //OnPropertyChanged("Year");
                }
            }
        }
        public String Description
        {
            get
            { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    //OnPropertyChanged("IdDescription");
                }
            }
        }
        public String Abv
        {
            get
            { return abv; }
            set
            {
                if (abv != value)
                {
                    abv = value;
                    //OnPropertyChanged("Abv");
                }
            }
        }
        public String Name
        {
            get
            { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    //OnPropertyChanged("Name");
                }
            }
        }

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

        //public event PropertyChangedEventHandler PropertyChanged;
        //public void OnPropertyChanged(string prop = "")
        //{
        //    if (PropertyChanged != null)
        //        PropertyChanged(this, new PropertyChangedEventArgs(prop));
        //}
    }
}
