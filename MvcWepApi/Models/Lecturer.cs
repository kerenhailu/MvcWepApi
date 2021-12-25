using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWepApi.Models
{
    public class Lecturer
    {
        public Lecturer(int id, string name, int money, int startYear, int[] arrayGread)
        {
            Id = id;
            Name = name;
            Money = money;
            StartYear = startYear;
            ArrayGread = arrayGread;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Money { get; set; }
        public int StartYear { get; set; }
        public int[] ArrayGread { get; set; }
    }
}