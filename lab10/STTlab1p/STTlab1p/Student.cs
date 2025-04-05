using System;

public class Student
{
    protected string Name; 
    protected int ID;      
    protected int Marks;   

    public Student(string Name, int ID, int Marks)
	{
		this.Name = Name;
		this.ID = ID;
		this.Marks = Marks;
	}
	public string getGrade()
	{
		if (this.Marks > 90)
		{
			return "A";
			}
		else if (this.Marks > 80)
		{
			return "B";
			}
		else if (this.Marks > 70)
		{
			return "C";
			}
		else if (this.Marks > 55)
		{
			return "D";
			}
		else if (this.Marks > 40)
		{
			return "E";
			}
		else
		{
			return "F";
			}
	}
	public int Main()
	{
		Console.WriteLine("Name: " + this.Name);
		Console.WriteLine("ID: " + this.ID);
		Console.WriteLine("Marks: " + this.Marks);
		Console.WriteLine("Grade: " + this.getGrade());
		return 0;
	}
}


public class StudentIITGN: Student
{
	private string Hostel_Name_IITGN;

	public StudentIITGN(string Name, int ID, int Marks, string Hostel_Name_IITGN) : base(Name, ID, Marks)
    {
		this.Hostel_Name_IITGN = Hostel_Name_IITGN;
	}
    public int Main()
    {
        Console.WriteLine("Name: " + this.Name);
        Console.WriteLine("ID: " + this.ID);
        Console.WriteLine("Marks: " + this.Marks);
        Console.WriteLine("Grade: " + this.getGrade());
		Console.WriteLine("Hostel_Name_IITGN: " + Hostel_Name_IITGN);
        return 0;
    }


}