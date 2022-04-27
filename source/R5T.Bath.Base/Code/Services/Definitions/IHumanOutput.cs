using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.Bath
{
    [ServiceDefinitionMarker]
    public interface IHumanOutput : IServiceDefinition
    {
        Task WriteLineAsync(string line);
        void WriteLine(string line);
    }
}
