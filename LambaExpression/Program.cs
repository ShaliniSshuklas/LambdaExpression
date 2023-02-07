using System;

namespace LambaExpression
{
	public class Program
	{
		public delegate bool IsTeenAger(Student student);
		public static void Main(string [] args)
        {
			IsTeenAger isTeenAger = s => s.Age > 12 && s.Age < 25;
			Student student = new Student() { Age = 24 };
			Console.WriteLine(isTeenAger(student));
		}
	}
	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
	}
}
