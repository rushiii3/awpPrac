// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
public class Box {
    double l,b,h;
    public Box(){
        l=1;
        b=1;
        h=1;
    }
    public Box(int length,int breadth){
        l=length;
        b= breadth;
        h=1;
    }
    public Box(int length,int breadth,int height){
        l=length;
        b= breadth;
        h=height;
    }
    public double  volume(){
        return l*b*h;
    }
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Box box1 = new Box();
        Console.WriteLine("Volume of box 1 "+box1.volume());
        Box box2 = new Box(10,20);
        Console.WriteLine("Volume of box 2 "+box2.volume());
        Box box3 = new Box(10,20,30);
        Console.WriteLine("Volume of box 3 "+box3.volume());
    }
}


// output
// Volume of box 1 1
// Volume of box 2 200
// Volume of box 3 6000
