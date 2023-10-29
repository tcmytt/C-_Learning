using System;

class Animal
{

    public virtual void Speak()
    {
        Console.WriteLine(" Animal is speaking. . .");
    }
}


class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine(" Cat is speaking. . .");
    }
}


class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine(" Dog is speaking. . .");
    }
}



namespace Cau_Truc_Lenh_Co_Ban
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat();
            Animal dog = new Dog();
            cat.Speak();
            dog.Speak();
        }
    }
}

