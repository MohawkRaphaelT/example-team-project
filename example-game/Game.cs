// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(1000, 800);
            Window.SetTitle("Horse");
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Blue);
            Draw.FillColor = Color.Red;
            Draw.Rectangle(300, 200, 400, 800);
            Console.WriteLine("Neigh.");
        }
    }
}
