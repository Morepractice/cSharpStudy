using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpDemo
{
    public class Student
    {
        public string Name { get; set; }

        public Student(string name)
        {
            Name = name;
        }

        public bool Equals(Student otherStudent)
        {
            if (ReferenceEquals(otherStudent, null))
            {
                return false;
            }

            if (ReferenceEquals(this, otherStudent))
            {
                return true;
            }

            return Name.Equals(otherStudent.Name);
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;

            return Equals(obj as Student);
        }

        public override int GetHashCode()
        {
            return Name?.GetHashCode() ?? 0;
        }

        public static bool operator ==(Student a, Student b)
        {
            return Equals(a, b);
        }

        public static bool operator !=(Student a, Student b)
        {
            return !Equals(a, b);
        }
    }
}
