using System;
namespace PolymorphismApp
{
public class RyanHomeBuilder{
public int X{get;private set;}
public int Y{get;private set;}

public virtual void BuildHomes(){
Console.WriteLine("this is the base builder draw method");
}


}
}