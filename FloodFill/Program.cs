namespace FloodFill;

class Program 
{
    static void Main(string[] args) 
    {
        int rows = 5;
        int cols = 5;

        // Create and initialize the grid
        Grid grid = new Grid(rows, cols);
        Console.WriteLine("Initial Grid:");
        grid.PrintGrid();

        while (!grid.IsGameCompleted()) 
        {
            Console.WriteLine("Choose any color (0-3) except for: " + grid.GetCell(0, 0));

            int targetNumber;
            if (int.TryParse(Console.ReadLine(), out targetNumber) && targetNumber >= 0 && targetNumber <= 3 && targetNumber != grid.GetCell(0, 0))
            {
                grid.FloodFill(0, 0, targetNumber);
                Console.WriteLine("Updated Grid:");
                grid.PrintGrid();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 3.");
            }
        }
        Console.WriteLine("Game Completed! All cells are the same color.");
    }
}
