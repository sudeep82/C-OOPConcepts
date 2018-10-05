using System;
namespace PolymorphismApp
{
public class MilanModel:RyanHomeBuilder{
    public override void BuildHomes(){
        Console.WriteLine("just built the Milan Home Model");

    }

    public override string ToString(){
        return "hello we just overrode a string";
    }
}
}