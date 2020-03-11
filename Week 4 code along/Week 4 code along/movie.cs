using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Week_4_code_along
{
    class Movie
    {
        public string Title { get; set; }
        public int ReleaseYear { get; set; }

        public double Tomatoes { get; set; }

        public Movie(string myTitle, int ReleaseYearInput, double Tomatoes)
        {
            this.Title = myTitle;
            this.ReleaseYear = ReleaseYearInput;
            this.Tomatoes = Tomatoes; 
        }

        public Movie()
        {
        }

        public void ShowDetails()
        {
            string info = "Title: " + this.Title;
            info += "\nRelease Year" + this.ReleaseYear;
            info += "\nTomatoes" + this.Tomatoes; 
            MessageBox.Show(info); 

        }
    }
}
