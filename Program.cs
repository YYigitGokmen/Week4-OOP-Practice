


using OOPWeek4Practice;
using System.ComponentModel.DataAnnotations;
using System;
public class Program
{
    public static void Main(string[] args)
    {
        
        //1- Konsol ekranından kullanıcıya telefon üretmek için
        //1 bilgisayar üretmek için 2'ye basması gerektiğini söyleyiniz.

        bool continueProducing = true;

        while (continueProducing)
        {
            Console.WriteLine("In order to produce phone, please press 1. For pc please press 2");
            string input = Console.ReadLine();

            //2- Kullanıcının seçimine göre ilgili classtan nesne
            //üreterek özelliklerini konsol ekranından yani kullanıcıdan alınız.
            if (input == "1")
            {
                Telephone telephone = new Telephone();
                telephone.NameOfTheProduct();
                telephone.DisplayDateTime();
                telephone.DisplayAllInformation();

            }

            else if (input == "2")
            {
                Pc pc = new Pc();
                pc.NameOfTheProduct();
                pc.DisplayDateTime();

                pc.DisplayAllInformation();

            }
            else
            {
                Console.WriteLine("Wrong input, please press 1 or 2");
            }
            Console.Write("Do you want to produce another product? (yes/no): ");
            string restartInput = Console.ReadLine();

            continueProducing = ConvertToBoolean(restartInput);

        }
        Console.WriteLine("Thank you for using the product producer!");

    }//I saw this method in chat gpt. It converts yes or no answers into boolean's true or false :)
    private static bool ConvertToBoolean(string input)
        {
            
            if (string.Equals(input, "yes", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else if (string.Equals(input, "no", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input. Exiting program.");
                return false; 
            }

    }

}

 

