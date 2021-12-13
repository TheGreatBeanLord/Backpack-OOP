using System;

namespace OOP_exersizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Backpack smallBlue = new Backpack("blue", "small", null, false);
            Backpack mediumRed = new Backpack("red", "medium", null, false);
            Backpack largeGreen = new Backpack("red", "medium", null, false);

            smallBlue.openBag();
            smallBlue.putIn("lunch");
            smallBlue.putIn("jacket");
            smallBlue.closeBag();
            smallBlue.openBag();
            Console.WriteLine(smallBlue.IsOpen);
            smallBlue.takeOut("jacket");
            smallBlue.closeBag();


        }
    }
}
