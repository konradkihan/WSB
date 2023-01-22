void zadanie2(int N)
{
    string[,] grid = new string[2*N,N];
    int rowLength = grid.GetLength(0)-1;
    int colLength = grid.GetLength(1)-1;

    for (int i = 0; i < colLength; i++)
        for (int j = 0; j < rowLength; j++)
            if (i == 0 || j == 0 || i == colLength || j == rowLength)
                grid[i, j] = "-";

    grid[0, 0] = "+";
    grid[0, colLength] = "+";
    grid[rowLength, 0] = "+";
    grid[rowLength, colLength] = "+";




    for (int i = 0; i <= colLength; i++)
        for (int j = 0; j <= rowLength; j++)
            Console.Write(grid[i, j]);
        Console.WriteLine("");
    
}

zadanie2(3);
zadanie2(4);
zadanie2(5);
zadanie2(6);