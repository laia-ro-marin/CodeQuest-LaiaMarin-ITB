using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8; //using emojis in the terminal

        // CHAPTER 1 CONSTANTS
        const string MENU_TITLE = "==== MAIN MENU - CODEQUEST ====";
        const string INPUT_CHAPTER = "CHAPTER 1: TRAIN TOUR WIZARD";
        const string INPUT_NAME_WIZARD = "Enter a name for your wizard:";

        const string EMPTY_SPACE = " ";

        const string MSG_MINUS_TWENTY = "You are retaking it in the second examination session, your rang is Raoden el Elantrí";
        const string MSG_TWENTY_THIRTY = "You still confuse the wand with a spoon, your rang is Zyn el Buguejat";
        const string MSG_THIRTY_THIRTYFIVE = "You are a Summoner of Magical Breezes, your rang is Arka Nullpointer";
        const string MSG_THIRTYFIVE_FOURTY = "Wow! You can summon dragons without burning down the laboratory! your rang is Elarion de les Brases";
        const string MSG_PLUS_FOURTY = "You have reached the rank of Master of the Arcane! your rang is ITB-Wizard el Gris";

        // CHAPTER 2 CONSTANTS
        const string INPUT_CHAPTER_TWO = "CHAPTER 2: CHECK THE DUNGEON";
        const string DRAGON_OUT = "The dragon 🐉 has detected your presence or has kicked you from the server.";
        const string DRAGON_NEXT_DOOR = "The dragon 🐉 respects you. You have unlocked the next level.";
        const string BEAT_DRAGON = "You have unlocked the final level. You can keep the dragon's 🐉 treasure💎!";
        const string ENTER_CODE_DOOR = "Enter the code for the door";
        const string CODE_DOOR_FILED = "The code is incorrect, try again";

        Random rdn = new Random();

        string nameWizard;
        int power = 0, level = 1, randomHours, randomPower;

        Console.WriteLine(MENU_TITLE);
        Console.WriteLine(EMPTY_SPACE);
        Console.WriteLine(INPUT_CHAPTER);
        Console.WriteLine(EMPTY_SPACE);
        Console.WriteLine(INPUT_NAME_WIZARD);

        nameWizard = Console.ReadLine();
        Console.WriteLine(EMPTY_SPACE);

        for (int days = 1; days <= 5; days++)
        {
            randomHours = rdn.Next(1, 25);
            randomPower = rdn.Next(1, 11);
            
            level = 1 + power / 10;
            power += randomPower;
            

            Console.WriteLine($"⌛ Day {days}: {nameWizard}, you have meditated for {randomHours} hours and now your power is {power} points");

            //Check if it levels up on that exact day, and if so, display an additional message
            if (level - 1 < power / 10)
            {
                level = power / 10;
                Console.WriteLine($"⭐ {nameWizard} has risen to the level {level + 1}");
            }
            
        }

        if (power < 20)
        {
            Console.WriteLine(MSG_MINUS_TWENTY);
        }
        else if (power >= 20 && power < 30)
        {
            Console.WriteLine(MSG_TWENTY_THIRTY);
        }
        else if (power >= 30 && power < 35)
        {
            Console.WriteLine(MSG_THIRTY_THIRTYFIVE);
        }
        else if (power >= 35 && power < 40)
        {
            Console.WriteLine(MSG_THIRTYFIVE_FOURTY);
        }
        else if (power >= 40)
        {
            Console.WriteLine(MSG_PLUS_FOURTY);
        }

        // CHAPTER 2 

        int door, attempts, inputCode, randomCode;
        bool correctDoor = false, beatDragon = true;

        Console.WriteLine(EMPTY_SPACE);
        Console.WriteLine(EMPTY_SPACE);
        Console.WriteLine(INPUT_CHAPTER_TWO);
        Console.WriteLine(EMPTY_SPACE);

        for (door = 0; door < 3; ++door)
        {
            correctDoor = false;
            randomCode = rdn.Next(1, 6);

            Console.WriteLine(ENTER_CODE_DOOR);

            for (attempts = 3; attempts > 0; --attempts)
            {
                inputCode = int.Parse(Console.ReadLine());

                if (inputCode == randomCode)
                {
                    Console.WriteLine(DRAGON_NEXT_DOOR);
                    Console.WriteLine(EMPTY_SPACE);
                    correctDoor = true;
                    break;
                }
                else
                {
                    Console.WriteLine(CODE_DOOR_FILED);
                    Console.WriteLine(EMPTY_SPACE);
                }
            }

            if (!correctDoor)
            {
                beatDragon = false;
                Console.WriteLine(DRAGON_OUT);
                break;
            }
        }

        if (beatDragon == true)
        {
            Console.WriteLine(BEAT_DRAGON);
        }
    }
}