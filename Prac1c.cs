using System;
using System.Collections;
using System.Collections.Generic;
class Prac1c
{
	public static void Main()
	{
		var idlist = new ArrayList();
		var namelist = new ArrayList();
		var courselist = new ArrayList();
		var doblist = new ArrayList();

		Console.WriteLine("Enter student id ");
		int idd =  Convert.ToInt32(Console.ReadLine());
		idlist.Add(idd);
		
		Console.WriteLine("Enter student name ");
		string name = Console.ReadLine();
		namelist.Add(name);

		Console.WriteLine("Enter student Course Name ");
		string course_name = Console.ReadLine();
		courselist.Add(course_name);

		Console.WriteLine("Enter student Date of Birth ");
		string dob = Console.ReadLine();
		doblist.Add(dob);

		for(var i = 0;i<idlist.Count;i++){
			Console.WriteLine("Student ID = "+idlist[i]);
			Console.WriteLine("Student Name = "+namelist[i]);
			Console.WriteLine("Student Course Name = "+courselist[i]);
			Console.WriteLine("Student Date of birth = "+doblist[i]);
		}
	
	}
}
