namespace InfosysPalindrome;

class Program
{
	static void Main(string[] args)
	{
		// Palindrome(); 
		// PalindromeFor(); 
		PalindromeA(); 
	}
	
	// using string reverse method 
	public static void Palindrome() { 
		Console.Write("Enter a possible palindrome: ");
		string originalInput = Console.ReadLine();
		char[] charArray = originalInput.ToCharArray();
		Array.Reverse(charArray); 
		string reversed = new string(charArray);
		
		bool IsPalindrome = originalInput == reversed; 
		
		Console.WriteLine((IsPalindrome)? $" {originalInput} is a palindrome": $"{originalInput} is not a palindrome");
	}
	
	// using no built in methods
	
	public static void PalindromeFor() { 
		
		Console.Write("Enter a possible palindrome: ");
		string Input = Console.ReadLine();
		
		bool IsPalindrome = true; 
		
		for (int i = 0; i < Input.Length / 2; i++) { 
			if (Input[i] != Input[Input.Length -i -1]) { 
				IsPalindrome = false; 
				break; 
			}
		}
		
		Console.WriteLine((IsPalindrome)? $" {Input} is a palindrome": $"{Input} is not a palindrome");
	}
	
	public static void PalindromeA() { 
		Console.WriteLine("enter a possible palindrome: "); 
		string Input = Console.ReadLine(); 
		
		char[] charArray = Input.ToCharArray(); 
		Array.Reverse(charArray); 
		string reversed = new string(charArray); 
		
		
		Console.WriteLine( (Input == reversed) ? $"{Input} is a palindrome" 
		: $"{Input}is not a palindrome" ); 
	}
}
