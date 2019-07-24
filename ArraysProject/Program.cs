using System;

namespace ArraysProject {
    class Program {
        static void Main(string[] args) {
            int[] frames = new int[10];

            frames[0] = 20;
            frames[1] = 27;
            frames[2] = 5;
            frames[3] = 11;
            frames[4] = 15;
            frames[5] = 8;
            frames[6] = 18;
            frames[7] = 29;
            frames[8] = 6;
            frames[9] = 22;

            int total = 0;
            int index = 0;
            while (index < 10) {
                total = total + frames[index];
                index = index + 1;
            }
            Console.WriteLine($"Total is {total}");
        }
    }
}
