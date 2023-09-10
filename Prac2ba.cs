using System;
class FunOver{
    public void shape(){
        Console.WriteLine ("The deafult shape is circle");
    }
    public void shape(string name){
        Console.WriteLine ("Now the shape is "+name);
    }
    public void shape(string name, int size){
        Console.WriteLine ("Now the shape is "+name+" and size is "+size);
    }
}
public class Prac2ba
{
    public static void Main(string[] args)
    {
        FunOver fo = new FunOver();
        fo.shape();
        fo.shape("square");
        fo.shape("square",4);
    }
}
// Output
// The deafult shape is circle
// Now the shape is square
// Now the shape is square and size is 4
