using Orleans;

namespace ElectricPOC.Abstractions;

public interface IHelloWorld : IGrainWithGuidKey
{
    Task<string> SayHelloWorld();
}
