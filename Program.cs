using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;

class Program
{
  //mathod 1 
    public static void Add(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine(sum);
    }

    
   
    
  
    
    //mathod 5 
    public static void subtract(int a, int b)
    {
        int sum = a - b;
        Console.WriteLine(sum);
    }
    
    //mathod 6 
    public static void multiply(int a, int b)
    {
        int sum = a * b;
        Console.WriteLine(sum);
    }
    
    //mathod 7
    public static void divide(int a, int b)
    {
        int sum = a / b;
        Console.WriteLine(sum);
    }
    public static void calculator(int a,string sighn,int b)
    {

        if (sighn == "*")
        {
            multiply(a,b);
        }

        else if (sighn == "/")
        {
            divide(a,b);
        }
        
        else if (sighn == "+")
        {
            Add(a,b);
        }

        else if(sighn == "-")
        {
            subtract(a,b);
        }
    }

    static void Main()
    {
        Console.WriteLine("enter first number");
        int a = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("enter second number number");
        int b = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("enter a sighn");
        string sighn  = Console.ReadLine();
        
        
       calculator(a,sighn,b);

      
    }
}