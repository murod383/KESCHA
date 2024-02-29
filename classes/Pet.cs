using KESCHA.Enums;

namespace KESCHA.Classes
{
    public class Pet : Animal
    {
        public PetType Type { get; set; }
        public Pet(string name, int age)
            : base(name, age)
        {

        }
        public override void Great(string userName)
        {
            Console.WriteLine($"Moew {userName}");
        }

        public override void Great2(string userName)
        {
            Console.WriteLine("Abstracted method implemented");
        }
    }
}
