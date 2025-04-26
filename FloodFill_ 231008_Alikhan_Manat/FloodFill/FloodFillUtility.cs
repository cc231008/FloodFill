namespace FloodFill;

class FloodFillUtility
{
    public static void DFS (int[,] grid, int x, int y, int oldNum, int newNum) 
    {
        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);

        // Check if the current position is out of bounds or if the color is not the same as the number in the left upper corner.
        if (x < 0 || x >= rows || y < 0 || y >= cols || grid[x, y] != oldNum)
            return;

        // Replace a number in a current cell with a new one.
        grid[x, y] = newNum;

        // Recursively call DFS for all four neighbors (up, down, left, right)
        // Check if a neighbor is the same number. If so, then replace it with a new number.
        DFS(grid, x + 1, y, oldNum, newNum); // Down
        DFS(grid, x - 1, y, oldNum, newNum); // Up
        DFS(grid, x, y + 1, oldNum, newNum); // Right
        DFS(grid, x, y - 1, oldNum, newNum); // Left
    }
}
