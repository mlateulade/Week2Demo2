using System;

class MainClass {
  public static void Main (string[] args) {
    /*add 2 numbers. If the sum is more than 100, display a message "Sum is more thab 100" otherwise do nothing.
    if sum is equal to 100, display Sum is equal to 100
    if sum == 500, divide sum by 2 toherwise divide sum by 3
    */
    Console.WriteLine("Enter a number");
    var x = Console.ReadLine();
    Console.WriteLine("Enter another number"); 
    var y =Console.ReadLine();
    
    int num1 = Convert.ToInt32(x);
    int num2 = Convert.ToInt32(y);

    int sum = num1 + num2;
    
  //If condition only
    //comparison >, <, ==, <=, >=
    if (sum > 100)
    {
      Console.WriteLine("Sum is more than 100");
    }
    if (sum == 100)
    {
      Console.WriteLine("Sum is equal to 100");
    }
    if (sum < 100)
    {
      Console.WriteLine("Sum is less than 100");
    }

  //If sum == 500, divide sum by 2 otherwise divide sum by 3
  if (sum == 500)
  {
    sum=sum/2;
    
  }
  else 
  {
    //block of code to be executed if the condition is False
   sum=sum/3;
  }

  Console.WriteLine(sum);
    
  }
}