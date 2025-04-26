
namespace FloodFill;

class Grid
{
    private int[,] cells;
    public int rows { get; private set; }
    public int cols { get; private set; }
    Random rand = new Random();

    public Grid(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        cells = new int[rows, cols];
        CreateGrid();
    }
    
    // CreateGrid() helps to create a grid with random numbers.
     private void CreateGrid()
    {   
        Random rand = new Random();
        
        for (int i = 0; i < rows; i++) 
        {
            for (int j = 0; j < cols; j++) 
            {
                cells[i, j] = rand.Next(0, 4); // Random numbers between 0 and 3
            }
        }
    }

    // PrintGrid() helps to print the grid in a readable format.
    public void PrintGrid()
    {
        for (int i = 0; i < rows; i++) 
        {
            for (int j = 0; j < cols; j++) 
            {
                Console.Write(cells[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // IsGameCompleted() helps to check if all cells are the same color.
    // If so, then the game is completed.
    public bool IsGameCompleted()
    {
        int firstValue = cells[0, 0];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (cells[i, j] != firstValue)
                    return false;
            }
        }
        return true;
    }

    // GetCell() helps to get a number in a cell by its coordinates.
    public int GetCell(int x, int y)
    {
        return cells[x, y];
    }

    // FloodFill() function uses DFS to fill the grid with a new color.
    public void FloodFill(int x, int y, int newColor)
    {
        int targetNumber = cells[x, y];
        FloodFillUtility.DFS(cells, x, y, targetNumber, newColor);
    }
}