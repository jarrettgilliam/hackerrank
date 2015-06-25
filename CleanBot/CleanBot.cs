using System;
using System.Collections.Generic;
using System.IO;

class Solution
{

    static void Main(String[] args)
    {
        String temp = Console.ReadLine();
        String[] position = temp.Split(' ');
        int[] pos = new int[2];
        String[] board = new String[5];
        for (int i = 0; i < 5; i++)
        {
            board[i] = Console.ReadLine();
        }
        for (int i = 0; i < 2; i++) pos[i] = Convert.ToInt32(position[i]);
        next_move(pos[0], pos[1], board);
    }

    static void next_move(int posr, int posc, String[] board)
    {
        int[] dirt;
        if (board[posr][posc] == 'd')
            Console.WriteLine("CLEAN");
        else
        {
            dirt = findDirt(board);

            //Console.WriteLine("Me   X:{0}, Y:{1}", posc, posr);
            //Console.WriteLine("Dirt X:{0}, Y:{1}", dirt[0], dirt[1]);

            if (posc < dirt[0])
                Console.WriteLine("RIGHT");
            else if (posc > dirt[0])
                Console.WriteLine("LEFT");
            else if (posr < dirt[1])
                Console.WriteLine("DOWN");
            else if (posr > dirt[1])
                Console.WriteLine("UP");
        }

    }

    static int[] findDirt(String[] board)
    {
        int j = 0;
        int i = 0;
        for (i = 0; i < 5; i++)
        {
            j = board[i].IndexOf('d');
            if (j > 0 || board[i][0] == 'd')
                break;
        }
        return new int[] { j, i };
    }
}
