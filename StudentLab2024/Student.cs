using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLab2024
{
    public class Student
    {
        public Student(string Name, string Hometown, string FavoriteFood)
        {
            this.name = Name;
            this.hometown = Hometown;
            this.favoriteFood = FavoriteFood;
        }


        public string name { get; set; }
        public string hometown {  get; set; }
        public string favoriteFood { get; set; }
    }
}
