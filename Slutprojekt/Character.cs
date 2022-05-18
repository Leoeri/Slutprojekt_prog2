using System;
using Raylib_cs;
using System.Collections.Generic;


class Character
{
    Random generator = new Random();

    protected int xCoord = 2;
    protected int yCoord = 1;
    protected int xCoord2 = 1;
    protected int yCoord2 = 1;
    public int[,] position = new int[5, 3];
    public bool aiTurn = false;
    public bool playerTurn = true;
    protected bool moved = true;
    protected bool up = false;
    protected bool down = false;
    protected bool right = false;
    protected bool left = false;
    public void movement()
    {
        position[xCoord, yCoord] = 1;
        position[xCoord2, yCoord2] = 2;
        for (int x = 0; x < position.GetLength(0); x++)
        {
            for (int y = 0; y < position.GetLength(1); y++)
            {
                moved = false;
                if (position[x, y] == 1)
                {
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT))
                    {
                        if (xCoord != 0)
                        {
                            xCoord -= 1;
                            moved = true;
                        }

                    }
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                    {
                        if (xCoord != 4)
                        {
                            xCoord += 1;
                            moved = true;
                        }

                    }
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_DOWN))
                    {
                        if (yCoord != 2)
                        {
                            yCoord += 1;
                            moved = true;
                        }
                    }
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_UP))
                    {
                        if (yCoord != 0)
                        {
                            yCoord -= 1;
                            moved = true;
                        }
                    }
                    if (moved)
                    {
                        for (int a = 0; a < position.GetLength(0); a++)
                        {
                            for (int b = 0; b < position.GetLength(1); b++)
                            {
                                position[a, b] = 0;
                                position[xCoord, yCoord] = 1;
                                playerTurn = false;
                                aiTurn = true;

                            }
                        }
                    }


                }
                if (position[x, y] == 2)
                {
                    int Choice = generator.Next(4);
                    switch (Choice)
                    {
                        case 1:
                            left = true;
                            break;
                        case 2:
                            right = true;
                            break;
                        case 3:
                            up = true;
                            break;
                        case 0:
                            down = true;
                            break;

                    }
                    if (left)
                    {
                        if (xCoord2 != 0)
                        {
                            xCoord2 -= 1;
                            moved = true;
                            left = false;
                        }

                    }
                    if (right)
                    {
                        if (xCoord2 != 4)
                        {
                            xCoord2 += 1;
                            moved = true;
                            right = false;
                        }

                    }
                    if (down)
                    {
                        if (yCoord2 != 2)
                        {
                            yCoord2 += 1;
                            moved = true;
                            down = false;

                        }
                    }
                    if (up)
                    {
                        if (yCoord2 != 0)
                        {
                            yCoord2 -= 1;
                            moved = true;
                            up = false;
                        }
                    }
                    if (moved)
                    {
                        for (int a = 0; a < position.GetLength(0); a++)
                        {
                            for (int b = 0; b < position.GetLength(1); b++)
                            {
                                position[a, b] = 0;
                                position[xCoord2, yCoord2] = 2;
                                playerTurn = true;
                                aiTurn = false;
                            }
                        }
                    }

                }
            }
        }


    }
}
