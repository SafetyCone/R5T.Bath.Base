using System;


namespace R5T.Bath
{
    public static class IHumanOutputExtensions
    {
        public static void WriteBlankLine(this IHumanOutput humanOutput)
        {
            humanOutput.WriteLine(String.Empty);
        }
    }
}
