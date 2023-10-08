/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 8.10.2023
 * Time: 20:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace codek
{
	/// <summary>
	/// Description of Student.
	/// </summary>
	public class Student
	{
		
		
		string Name;
		string SurName;
		string Group;
		double Point;
		bool isGraduated = false;
		
		
		public Student(string Name, string SurName, string Group, double Point)
		{
			
			this.Name = Name;
			this.SurName = SurName;
			this.Group = Group;
			this.Point = Point;
			
			if (Point > 65)
			{
				
				isGraduated = true;
				
			}
			
		}
		
		public void GetInfo()
		{
			
			Console.WriteLine("Name: " + Name);
			Console.WriteLine("SurName: " + SurName);
			Console.WriteLine("Group: " + Group);
			Console.WriteLine("Point: " + Point);
			Console.WriteLine("Graduation: " + isGraduated);
			
		}
		
		public void CheckGraduation()
		{
			if (isGraduated)
			{
				Console.WriteLine(Name + " has graduated with " + Point + " points! ");
			}
			else 
			{
				Console.WriteLine(Name + " could not graduate with " + Point + " points... T-T ");
			}
		}
		
		
		public void GetDiplomDegree()
		{
			if (Point >= 90)
			{
				Console.WriteLine(Name + " achieved High Honor!!!");
			}
			else if (Point >= 80)
			{
				Console.WriteLine(Name + " achieved Honor!");
			}
			else if (Point >= 65)
			{
				Console.WriteLine(Name + " achieved felicitation.");
			}
			else
			{
				Console.WriteLine(Name + " failed graduation...");
			}
		}
		
	}
}
