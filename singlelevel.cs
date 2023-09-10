using System;
public class Parent {
    public void showParent(){
        Console.WriteLine("Im a parent");
    }
}
public class Child:Parent{
    public void show(){
        showParent();
        Console.WriteLine("Im a Child");
    }
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Child child = new Child();
        child.show();
    }
}

// output 
// Im a parent
// Im a Child
