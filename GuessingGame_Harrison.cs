using System;

public class GuessingGame
{
    public static void Main(string[] args)
    {

       Random rand = new Random();
        int theCompNum = 0;
        int theGuess = 0;
        int tryCount = 1;

        theCompNum = rand.Next(1001);

        Console.WriteLine("Try Guessing my number! (Hint: Its in a range from 0 to 1000)");

        theGuess = Convert.ToInt32(Console.ReadLine());
            while(!(theCompNum == theGuess)){
                tryCount++;
                Console.WriteLine("Thats not my number ");
                if(theGuess > theCompNum) {
                    Console.WriteLine("your number is too high. Try again!");
                }
                else{
                    Console.WriteLine("your number is too low. Try again!");

                }
                theGuess = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Congrats, You guessed my number!!! It was " + theCompNum + ".\nIt took you only " + tryCount + " guesses!");
        
    }
}