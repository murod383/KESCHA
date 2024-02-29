namespace KESCHA.Classes
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int AgeDifference { get; set; }
        public DateTimeOffset CreatedDate { get; set; }

        public Animal()
        {
            Name = "No name";
            Age = 0;
            AgeDifference = 0;
            CreatedDate = DateTimeOffset.Now;
        }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            CreatedDate = DateTimeOffset.Now;

        }
        public Animal(
            string name,
            int userAge,
            int animalAge)
        {
            Name = name;
            Age = animalAge;
            CalculateAgeDifferenceWithNoReturn(userAge, animalAge);
            CreatedDate = DateTimeOffset.Now;

        }

        public abstract void Great2(string userName);
        public void PrintAgeDifference()
        {
            Console.WriteLine($"The difference between yuor and {Name}`s age is {AgeDifference}");
        }

        public void CompareAges(int userAge)
        {
            if (userAge > Age)
            {
                Console.WriteLine("You are older than Kescha");
            }
            else if (userAge == Age)
            {
                Console.WriteLine("You are equal");
            }
            else
            {
                Console.WriteLine("You are younger than Kescha");
            }

        }
        public virtual void Great(string userName)
        {
            if (userName == "")
            {
                userName = "Uknown person";
            }
            Console.WriteLine($"Hello {userName}");

        }

        public void TellAboutFriends(string userName, int userAge)
        {
            Console.WriteLine("Let me tell you about my friends");
            string[] friendsName = new string[3];
            friendsName[0] = "Kescha";
            friendsName[1] = "Vasya";
            friendsName[2] = userName;
            int[] friendsAge = { 1, 2, userAge };
            for (int iteration = 0; iteration < friendsName.Length; iteration++)
            {
                Console.WriteLine($"{friendsName[iteration]} is {friendsAge[iteration]} years old!");
            }
        }


        public void CalculateAgeDifferenceWithNoReturn(int userAge)
        {
            AgeDifference = userAge - Age;
        }
        public int CalculateAgeDifference(int userAge, int animalAge)
        {
            return userAge - Age;
        }
        private void CalculateAgeDifferenceWithNoReturn(int userAge, int animalAge)
        {
            AgeDifference = userAge - animalAge;
        }

    }
}

