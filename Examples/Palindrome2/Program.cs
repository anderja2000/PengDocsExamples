namespace Palindrome2;

class Program
{
	static void Main(string[] args)
	{
		Palindrome();
	}

	public static void P()
	{
		Console.Write("Enter a word: ");
		string myInput = Console.ReadLine();



		bool isP = true;
		for (int i = 0; i < myInput.Length / 2; i++)
		{
			if (myInput[i] != myInput[myInput.Length - i - 1])
			{
				isP = false;
				break;
			}

		}
		if (isP == false)
		{
			Console.Write("Your word is not a palindrone");
		}
		else
		{
			Console.Write("Your word is not a palindrone");
		}
	}

}

