using System;
using System.Collections.Generic;
using System.Text;

namespace Task8Ape3
{
    internal class Book
    {
        public int number;
        public static int count = 1;
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code;

        public Book( string name,string authorname,int pagecount)
        {
            Name = name;
            AuthorName = authorname;
            PageCount = pagecount;
            number = count;
            count++;
            Code =GetCode();
        }

        public string GetCode()
        {
            return Name[0].ToString().ToUpper() + Name[1].ToString().ToUpper() +"-" +number;
        }
      

    }
}
