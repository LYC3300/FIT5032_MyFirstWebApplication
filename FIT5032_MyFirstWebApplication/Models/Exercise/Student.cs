using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_MyFirstWebApplication.Models.Exercise
{
    public class Student
    {
        public String Name { get; set; }
        public String PhoneNumber { get; set; }
        public Student(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
    }
    public class ExampleDictionary
    {
        public void Example()
        {
            Dictionary<int, Student> studentDictionary = new Dictionary<int, Student>();
            Student s1 = new Student("John", "0412345678");
            Student s2 = new Student("Mary", "0412345679");

            studentDictionary.Add(1, s1);
            studentDictionary.Add(2, s2);
            Student result = new Student("", "");
            studentDictionary.TryGetValue(1, out result);
            
        }
        
    }
}