using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8; //using emojis in the terminal

        const string MENU_TITLE = "==== MAIN MENU - CODEQUEST ====";
        const string INPUT_CHAPTER = "CHAPTER 1: TRAIN TOUR WIZARD";
        const string INPUT_NAME_WIZARD = "Enter a name for your wizard";

        //

        const string MSG_MINUS_TWENTY = "You are retaking it in the second examination session, your rang is Raoden el Elantrí";
        const string MSG_TWENTY_THIRTY = "You still confuse the wand with a spoon, your rang is Zyn el Buguejat";
        const string MSG_THIRTY_THIRTYFIVE = "You are a Summoner of Magical Breezes, your rang is Arka Nullpointer";
        const string MSG_THIRTYFIVE_FOURTY = "Wow! You can summon dragons without burning down the laboratory! your rang is Elarion de les Brases";
        const string MSG_PLUS_FOURTY = "You have reached the rank of Master of the Arcane! your rang is ITB-Wizard el Gris";

        Random rdn = new Random();

        string nameWizard;
        int power = 0, level = 1, randomHours, randomPower;

        Console.WriteLine(MENU_TITLE);
        Console.WriteLine(INPUT_CHAPTER);
        Console.WriteLine(INPUT_NAME_WIZARD);

        nameWizard = Console.ReadLine();

        for (int days = 1; days <= 5; days++)
        {
            randomHours = rdn.Next(1, 25);
            randomPower = rdn.Next(1, 11);
            //
            level = 1 + power / 10;
            power += randomPower;
            

            Console.WriteLine($"⌛ Day {days}: {nameWizard}, you have meditated for {randomHours} hours and now your power is {power} points");
            
            //Controlar si ese dia exacto sube de nivel mostrar mensaje extra
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
    }
}