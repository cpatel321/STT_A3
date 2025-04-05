using System;

public class Loops
{
	public Loops()
	{
		for ( int i=1; i<11; i++)
		{
			Console.WriteLine(i);
		}
		string inp = null;
		while (inp != "exit") {
			Console.WriteLine("Enter 'exit' to Exit the loop.");
			inp = Console.ReadLine();
		}
	
	}
    public int Fact(int i)
    {
        if (i == 0 || i == 1)
        {
            return 1;
        }
        else
        {
            return i * Fact(i - 1);
        }
    }
}
