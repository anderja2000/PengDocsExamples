using System.Dynamic;

public class Penguino {
	

 public string Name {get; set;}
 public int Age {get; set;}

 public Penguino (string name, int age)
 {Name = name;
 Age = age;}

 public void GrabPengi(){
    Console.Write($"hello {Name}, Age {Age}");
    
 }

 
}   