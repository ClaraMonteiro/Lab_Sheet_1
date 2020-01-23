using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Sheet_1
{
    class Band : IComparable
    {

        public string Name { get; set; }

        public int Year { get; set; }

        public string Members { get; set; }

        public Band (string name, int year, string members)
        {
            Name = name;
            Year = year;
            Members = members;
        }

        public Band()
        {
        }

        public override string ToString()
        {
            return $"{Year} {Members}";
        }

        public int CompareTo(Band other)
        {
            return this.Name.CompareTo(other.Name);
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
