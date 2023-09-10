// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
public class GrandParent1 {
    public void showGrandParent(){
        Console.WriteLine("Im a Grandparent");
    }
}
public class Parent:GrandParent1 {
    public void showParent(){
        showGrandParent();
        Console.WriteLine("Im a parent");
    }
}
public class Child:GrandParent1{
    public void show(){
        showGrandParent();
        Console.WriteLine("Im a Child");
    }
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Parent parent = new Parent();
        parent.showParent();
        Child child = new Child();
        child.show();
        
    }
}

// output
// Im a Grandparent
// Im a parent
// Im a Grandparent
// Im a Child
