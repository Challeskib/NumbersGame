using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = RandomEasy(); //kallar på metoden och lagrar randomnumber i en variabel


            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Gissa vilket? Du får fem försök ");

            int guessCount = 0; //Variabel som hjälper oss att  hålla reda på om vi förlorade

            for (int i = 0; i < 5; i++) //Loop som ser till att vi bara kör 5 iterationer = fem gissningar
            {
                guessCount++; //För varje iteration ++guessCount


                int userAnswer = int.Parse(Console.ReadLine()); //User får gissa

                if (userAnswer == randomNumber) //Jämför användarens input med random number
                {
                    Console.WriteLine("Woho! Du gjorde det!");
                    i = 5; //För att hoppa ut ur loopen
                    guessCount = 0; //Ändrar Variabel till 0 så att vi inte får loser-message

                }
                else if (userAnswer < randomNumber) //Om userAnswer är mindre än randomNumber
                {
                    Console.WriteLine("Tyvärr du gissade för lågt");
                }
                else //Om userAnswer är större än randomNumber
                {
                    Console.WriteLine("Tyvärr du gissade för högt!");
                }

            }

            if (guessCount == 5) //Förlorar-message 
            {
                Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
            }


        }

        public static int RandomEasy() //Metod som returnerar ett slumpat nummer 1-10
        {
            Random random = new Random(); //Skapar en instance av klassen Random
            int randomEasyNumber = random.Next(1, 11); //Lagrar ett random number i randomEasyNumber

            return randomEasyNumber; //returnerar random nummer

        }
    }
    
}
