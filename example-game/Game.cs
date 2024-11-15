using System;
using System.Numerics;

namespace Game10003;

// My epic game
public class Game
{
    public void Setup()
    {

        // This window is awesome
        Window.SetTitle("bWindow");
        Window.SetSize(1337, 1337);

    }
    public void Update()
    {

        // Epic rectangle
        Window.ClearBackground(new Color(233, 11, 112));
        Draw.FillColor = Color.White;
        Draw.Rectangle(50, 50, 22, 22);
        // Who needs communication with teammates?
    }
}
