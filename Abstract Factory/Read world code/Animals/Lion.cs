using System;

/// <summary>
/// Creates an instance of several families of classes.
/// 
/// Provide an interface for creating families of related or
/// dependent objects without specifying their concrete classes.
/// 
/// Frequence of use: 5 high.
/// </summary>
namespace DoFactory.GangOfFour.Abstract.RealWorld
{
    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Wildebeest
            Console.WriteLine(GetType().Name +
              " eats " + h.GetType().Name);
        }
    }
}