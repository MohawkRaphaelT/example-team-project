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
            // Draw
            Window.SetSize(1000, 1000);
            Window.SetTitle("CHAOS");
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Background Color
            Window.ClearBackground(Color.Cyan);

            // Rectangle
            Draw.LineSize = 0;
            Draw.FillColor = Color.Blue;

            Draw.Rectangle(100, 100, 200, 200);
        }
    }
}
