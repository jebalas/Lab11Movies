using System;
namespace Lab11ListObjects
{
    public class Movie
    {
        private string _title;
        private string _category;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value != "")
                {
                    _title = value;
                }
                else
                {
                    throw new Exception("Title was blank! ");
                }
            }
        }

        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                if (value == "animated" || value == "drama" || value == "horror" || value == "scifi")
                {
                    _category = value;
                }
                else
                {
                    throw new Exception("Invalid category! ");
                }
            }
        }

        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }
    }
}
