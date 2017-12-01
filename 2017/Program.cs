using System;

namespace AdventOfCode2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Advent Of Code 2017");
            Console.WriteLine("-------------------");
            Console.WriteLine();

            Console.WriteLine("Day 1 - Puzzle 1");
            Console.WriteLine("================");
            Console.WriteLine((new Day1(){ Input = "1122" }).Puzzle1());
            Console.WriteLine((new Day1(){ Input = "1111" }).Puzzle1());
            Console.WriteLine((new Day1(){ Input = "1234" }).Puzzle1());
            Console.WriteLine((new Day1(){ Input = "91212129" }).Puzzle1());
            Console.WriteLine(new Day1().Puzzle1());

            Console.WriteLine("Day 1 - Puzzle 1");
            Console.WriteLine("================");
            Console.WriteLine((new Day1(){ Input = "1212" }).Puzzle2());
            Console.WriteLine((new Day1(){ Input = "1221" }).Puzzle2());
            Console.WriteLine((new Day1(){ Input = "123425" }).Puzzle2());
            Console.WriteLine((new Day1(){ Input = "123123" }).Puzzle2());
            Console.WriteLine((new Day1(){ Input = "12131415" }).Puzzle2());
            Console.WriteLine(new Day1().Puzzle2());

        }
    }
}
