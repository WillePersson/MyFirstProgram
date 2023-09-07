//wille persson Klass:.NET23

using System.ComponentModel;

namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x; //Declaration, used to declare what the varaible is 
            x = 7; //initialization, what is in the variable
           
            //if-sats, if the thing we are looking at is bigger than 10 it will
            //tell us that it is big
            if (x > 10)
            {
                Console.WriteLine("Talet är stort!");
            }
           
            //else if, if its not true in the if-sats it will look trough this 
            //instead and tell us this instead
            else if (x < 10) 
            {
                Console.WriteLine("Oj Lågt tal!");
            }
           
            //simple WriteLine,Strign wiht a variable witch is name here
            //then if the user put in the name it will tell them hej and the name
            //they put in
            Console.WriteLine("Vad heter du?");
            String name = Console.ReadLine();
            Console.WriteLine("Hej " + name +"!");

            
             //(for loop) repeats soem code a Finite amount of times
            for (int z = 0; z <= 7; z++)
            {
                Console.WriteLine(z);
            }
           
            
        }
    }
}