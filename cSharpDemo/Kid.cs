using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDemo
{
    internal class Kid
    {
        [Range(0, 18, ErrorMessage = "Price must be between 0 and 18")]
        public int Age { get; set; }

        [StringLength(maximumLength:50,MinimumLength = 3)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        public Kid(int age, string name, DateTime birthday)
        {
            Age = age;
            Name = name;
            Birthday = birthday;
        }
    }
}
