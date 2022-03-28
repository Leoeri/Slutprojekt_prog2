using System;
using Raylib_cs;

int xCoord = 3;
int yCoord = 7;

Raylib.InitWindow(1000, 1000, "Hello World");

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.BROWN);

    spelplan();
    Raylib.EndDrawing();
    //  Console.WriteLine("Hello World!");

    // Console.ReadLine();


}


void spelplan()
{
    for (int y = 0; y <= 9; y++)
    {
        for (int x = 0; x <= 9; x++)
        {
            Raylib.DrawRectangle(x * 100 - 1, y * 100 - 1, 99, 99, Color.GREEN);
            if (x == xCoord && y == yCoord)
            {
                Console.Write("[X]");
            }
            else
            {
                Console.Write("[ ]");
            }

        }
        Console.WriteLine();
    }
}