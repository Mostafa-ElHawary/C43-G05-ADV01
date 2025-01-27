using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_ADV01.Generic
{
    internal class Employee : IComparable<Employee> , IEquatable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary   { get; set; }

        // Operator Overloading

        public static bool operator ==(Employee left, Employee right)  
        {
            if (ReferenceEquals(left, right)) return true;
            if (left is null || right is null) return false;
            return left.Id == right.Id && 
                   left.Name == right.Name && 
                   left.Age == right.Age && 
                   left.Salary == right.Salary;
        }

        public static bool operator !=(Employee left, Employee right)
        {
            return !(left == right);
        }

        //public override bool Equals(object obj)
        //{ 
        //    Employee E = (Employee) obj;
        //    return this == E;
        //}

        public bool Equals(Employee? other)
        {
            if (other is null) return false;
            return this == other;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}";
        }

        public int CompareTo(Employee? other)
        {
            if (other == null) return 1;
            return Age.CompareTo(other.Age);
        }
    }
}
