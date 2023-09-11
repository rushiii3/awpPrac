// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
 interface I1{
    public void showage();    
}
 interface I2{
     public void showno();
}
public class Multiple:I1,I2{
    public void name(string uname){
        Console.WriteLine ("The Name of the user is {0} \n",uname);
    }
    public void showage(){
        Console.WriteLine ("The age is 24 \n");
    }
    public void showno(){
        Console.WriteLine ("The phone number is 345672893 \n");
    }
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Multiple mul = new Multiple();
        mul.name("Rushi");
        mul.showage();
        mul.showno();
    }
}
// output
// The Name of the user is Rushi 

// The age is 24 

// The phone number is 345672893 
