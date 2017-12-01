using System;

namespace AdventOfCode2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Advent of Code 2016");
            Console.WriteLine("-------------------");
            Console.WriteLine();

            Console.WriteLine("Day 1, Part 1");
            Console.WriteLine(new Day1Part1().Execute());
        }
    }

    public class Day1Part1
    {
        public string Input => "R4, R3, R5, L3, L5, R2, L2, R5, L2, R5, R5, R5, R1, R3, L2, L2, L1, R5, L3, R1, L2, R1, L3, L5, L1, R3, L4, R2, R4, L3, L1, R4, L4, R3, L5, L3, R188, R4, L1, R48, L5, R4, R71, R3, L2, R188, L3, R2, L3, R3, L5, L1, R1, L2, L4, L2, R5, L3, R3, R3, R4, L3, L4, R5, L4, L4, R3, R4, L4, R1, L3, L1, L1, R4, R1, L4, R1, L1, L3, R2, L2, R2, L1, R5, R3, R4, L5, R2, R5, L5, R1, R2, L1, L3, R3, R1, R3, L4, R4, L4, L1, R1, L2, L2, L4, R1, L3, R4, L2, R3, L1, L5, R4, R5, R2, R5, R1, R5, R1, R3, L3, L2, L2, L5, R2, L2, R5, R5, L2, R3, L5, R5, L2, R4, R2, L1, R3, L5, R3, R2, R5, L1, R3, L2, R2, R1";
        //public string Input => "L5, L5, L5";
        public string Execute()
        {
            var directions = Input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

            var coord = new int[] { 0, 0, 0 };
            var index = 1;
            var facing = 2;

            foreach(var instruction in directions)
            {
                var turn = instruction[0];
                index = index == 1 ? 0 : 1;

                coord[facing] = Math.Abs(coord[facing] + (360 + (90 * (turn == 'R' ? 1 : -1)))) % 360;
                coord[index] = coord[index] + (Convert.ToInt32(instruction.Substring(1)) * (coord[facing] > 90 ? -1 : 1));
            }

            return $"Facing {coord[facing]} you are X {coord[0]} and Y {coord[1]} from your starting location.  Total distance is {Math.Abs(coord[0]) + Math.Abs(coord[1])}";
        }
    }
}
