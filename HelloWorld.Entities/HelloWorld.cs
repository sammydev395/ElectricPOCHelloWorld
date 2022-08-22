using ElectricPOC.Abstractions;
using Orleans;

namespace ElectricPOC.Entities;

public class HelloWorld : Grain, IHelloWorld
{
    public Task<string> SayHelloWorld()
    {
        return Task.FromResult("Hello World");
    }
}
