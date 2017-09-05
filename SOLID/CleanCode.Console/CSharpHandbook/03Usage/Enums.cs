using System;


namespace CleanCode.Console.CSharpHandbook._03Usage
{
    [Flags]
    public enum QuerySections
    {
        None = 0x00,
        Select = 0x01,
        From = 0x02,
        Where = 0x04,
        OrderBy = 0x08,
        NotOrderBy = All & ~OrderBy,
        All = Select | From | Where | OrderBy,
    }

    [Flags]
    public enum NumberFlags
    {
        None = 0,
        First = 1 << 0,
        Second = 1 << 1,
        Third = 1 << 2,
        Fourth = 1 << 3
    }


    public class Enums
    {
        static NumberFlags AllowedNumbers = NumberFlags.First | NumberFlags.Second;

        public static void TestEnums()
        {
            var result = NumberFlags.First | NumberFlags.Second;

            if (AllowedNumbers.HasFlag(result))
            {
                System.Console.WriteLine("Yes has flag");
            }         
        }
    }
}
