using KESCHA.Classes;
using KESCHA.Enums;

namespace KESCHA
{
    class Program
    {
        static void Main()
        {
            try
            {
                Bird kescha = new Bird(name: "Kescha", age: 6);
                Pet kasse = new Pet(name: "Kasse", age: 5);
                kasse.Type = PetType.Cat;
                kescha.Type = BirdType.kescha;

                Console.WriteLine("Kescha was created: " + kescha.CreatedDate);
                Console.WriteLine("Kasse was created: " + kasse.CreatedDate);
                Console.WriteLine(kasse.Type);
                Console.WriteLine(kescha.Type);

                Console.Write("Enter yuor name: ");
                string userName = Console.ReadLine();
                Console.WriteLine("Kescha says:");
                kescha.Great(userName);
                Console.WriteLine("Kasse  says:");
                kasse.Great(userName);
                kasse.Great2(userName);

                Console.Write("Enter your age: ");
                string ageAsString = Console.ReadLine();

                Console.WriteLine("Converting...");
                int userAge = Convert.ToInt32(ageAsString);
                Console.WriteLine($"Succesfuly converted! {userAge}");

                kescha.CalculateAgeDifferenceWithNoReturn(userAge);
                kescha.PrintAgeDifference();
                kescha.CompareAges(userAge);
                kescha.TellAboutFriends(userName, userAge);

            }
            catch (FormatException formatException)
            {
                Console.WriteLine($"Error was thrown.Message: {formatException.Message}");
            }
            catch (Exception excaption)
            {
                Console.WriteLine("Error was thrown. Type is not known ");
            }
            Console.WriteLine("Program ended..");

        }
    }
}