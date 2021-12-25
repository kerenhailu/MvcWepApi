using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWepApi.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gread { get; set; }
        public int Year { get; set; }
        public int[] ArrayGread { get; set; }

        public Student(int id, string name, string gread, int year, int[] arrayGread)
        {
            Id = id;
            Name = name;
            Gread = gread;
            Year = year;
            ArrayGread = arrayGread;
        }
    }
}