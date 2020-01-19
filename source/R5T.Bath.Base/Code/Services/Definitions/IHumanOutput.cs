using System;
using System.Threading.Tasks;


namespace R5T.Bath
{
    public interface IHumanOutput
    {
        Task WriteLineAsync(string line);
        void WriteLine(string line);
    }
}
