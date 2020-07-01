using System;

class MainClass {
  public static void Main (string[] args) {
  
  Console.WriteLine("Enter a number to check if prime");
  int number;
  number = Convert.ToInt32(Console.ReadLine());
  int check;
  check = 0;
  for(int i = 1; i <= number; i++)
  if(number % i == 0)
  {
    check++;
  }

  if(check == 2)
  {
    Console.WriteLine(number + " is prime");
  }
  else
  {
    Console.WriteLine(number + " is not prime");
  }
  }
}