using System;
using System.Collections.Generic;
using System.IO;
class Solution
{

    static void Main(String[] args)
    {
        int n;

        n = int.Parse(Console.ReadLine());
        String pos;
        pos = Console.ReadLine();
        String[] position = pos.Split(' ');
        int[] int_pos = new int[2];
        int_pos[0] = Convert.ToInt32(position[0]);
        int_pos[1] = Convert.ToInt32(position[1]);
        String[] grid = new String[n];
        for (int i = 0; i < n; i++)
        {
            grid[i] = Console.ReadLine();
        }
        nextMove(n, int_pos[0], int_pos[1], grid);
    }

    static void nextMove(int n, int r, int c, String[] grid)
    {
        int[] me_pos = new int[] { c, r };
        int[] pc_pos = findPrincess(n, grid);

        //Console.WriteLine("Me X:{0}, Y:{1}", me_pos[0], me_pos[1]);
        //Console.WriteLine("Pc X:{0}, Y:{1}", pc_pos[0], pc_pos[1]);

        if (me_pos[0] < pc_pos[0])
            Console.WriteLine("RIGHT");
        else if (me_pos[0] > pc_pos[0])
            Console.WriteLine("LEFT");
        else if (me_pos[1] < pc_pos[1])
            Console.WriteLine("DOWN");
        else if (me_pos[1] > pc_pos[1])
            Console.WriteLine("UP");
    }

    static int[] findPrincess(int n, String[] grid)
    {
        int j = 0;
        int i = 0;
        for (i = 0; i < n; i++)
        {
            j = grid[i].IndexOf('p');
            if (j > 0 || grid[i][0] == 'p')
                break;
        }
        return new int[] { j, i };
    }
}
