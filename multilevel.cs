using System;
public class GrandParent1 {
    public void showGrandParent(){
        Console.WriteLine("Im a Grandparent");
    }
}
public class Parent:GrandParent1 {
    public void showParent(){
        Console.WriteLine("Im a parent");
    }
}
public class Child:Parent{
    public void show(){
        showGrandParent();
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
// Im a Grandparent
// Im a parent
// Im a Child
