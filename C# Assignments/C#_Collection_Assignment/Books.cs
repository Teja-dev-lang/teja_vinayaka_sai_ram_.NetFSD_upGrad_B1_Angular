using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace C__Collection_Assignment
{
    public class Books
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return $"Id : {Id}, Name :{Name} ,Price : {Price}, Category : {Category}";
        }
    }
}
