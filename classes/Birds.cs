using KESCHA.Enums;

namespace KESCHA.Classes
{
    public class Bird : Animal
    {
        public BirdType Type { get; set; }
        public Bird(string name, int age)
            : base(name, age)
        {

        }
        public override void Great(string userName)
        {
            Console.WriteLine($"Hello {userName} ");
        }

        public override void Great2(string userName)
        {
            Console.WriteLine("Abstracted method implemented");
        }
    }
}