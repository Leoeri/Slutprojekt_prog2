using System;
using Raylib_cs;

int[,] taken = new int[5, 3];
taken[1, 1] = 3;
taken[3, 1] = 3;
PlayerCharacter player = new PlayerCharacter();
AICharacter ai = new AICharacter();

Raylib.InitWindow(500, 300, "Hello World");

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.BROWN);
    spelplan();
    if (ai.playerTurn)
    {
        player.movement();
    }
    if (player.aiTurn)
    {
        ai.movement();
    }

    Raylib.EndDrawing();

}


void spelplan()
{
    for (int y = 0; y <= 2; y++)
    {
        for (int x = 0; x <= 4; x++)
        {
            Raylib.DrawRectangle(x * 100 - 1, y * 100 - 1, 99, 99, Color.GREEN);
            if (taken[x, y] == 3)
            {
                Console.Write("[X]");
                Raylib.DrawRectangle(x * 100 - 1, y * 100 - 1, 99, 99, Color.BLUE);
            }
            else if (player.position[x, y] == 1)
            {
                Raylib.DrawRectangle(x * 100 - 1, y * 100 - 1, 99, 99, Color.GRAY);
            }
            else if (ai.position[x, y] == 2)
            {
                Raylib.DrawRectangle(x * 100 - 1, y * 100, 99, 99, Color.WHITE);
            }

        }
        Console.WriteLine();
    }
}