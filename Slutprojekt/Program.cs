using System;
using Raylib_cs;




Raylib.InitWindow(1000, 1000, "Hello World");

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);

    spelplan();
    Raylib.EndDrawing();
    //  Console.WriteLine("Hello World!");

    // Console.ReadLine();


}


static void spelplan()
{

    for (int x = 0; x <= 9; x++)
    {
        for (int y = 0; y <= 9; y++)
        {
            Raylib.DrawRectangle(y * 100 - 1, x * 100 - 1, 99, 99, Color.BLACK);

        }

    }

}