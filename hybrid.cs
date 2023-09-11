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
public class Son:Parent{
    public void show(){
        showGrandParent();
        showParent();
        Console.WriteLine("Im a Son");
    }
}
public class Daughter:Parent{
    public void show(){
        showGrandParent();
        showParent();
        Console.WriteLine("Im a Daughter");
    }
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Son son = new Son();
        son.show();
        Daughter daughter = new Daughter();
        daughter.show();
    }
}
// output
// Im a Grandparent
// Im a parent
// Im a Son
// Im a Grandparent
// Im a parent
// Im a Daughter
