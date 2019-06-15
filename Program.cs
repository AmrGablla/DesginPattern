using System;

namespace DPLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            // //Decorator Pattern
            // Console.WriteLine("Decorator Pattern\n");
            // Icomponent component = new component();
            // Display("1. Basic component: ", component);
            // Display("2. A-decorated : ", new DecoratorA(component));
            // Display("3. B-decorated : ", new DecoratorB(component));
            // Display("4. B-A-decorated : ", new DecoratorB(new DecoratorA(component)));
            // // Explicit DecoratorB
            // DecoratorB b = new DecoratorB(new component());
            // Display("5. A-B-decorated : ", new DecoratorA(b));
            // // Invoking its added state and added behavior
            // Console.WriteLine(value: "\t\t\t" + b.AddedState + b.AddedBehavior());



            //Bridge Pattern
           // Console.WriteLine(new Abstraction(new ImplementationA()).Operation());

        }

        private static void Display(string v, Icomponent c)
        {
            Console.WriteLine(v + c.Operation());
        }
    }
}
