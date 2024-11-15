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
            // I'm good at git maybe
            Window.SetTitle("RAPH's cool thing");
            Window.SetSize(234, 234);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Clear background
            Window.ClearBackground(Color.Gray);

            // Draw quarter circle in corner
            Draw.FillColor = Color.Magenta;
            Draw.Circle(234, 234, 100);
        }
    }
}
