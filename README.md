## About The Project
The Flood Fill Algorithm is a technique used in computer graphics and grid-based problems to determine and fill a connected region of similar values with a new value. It's commonly used in applications like paint programs (e.g., the "bucket fill" tool) or solving grid-based puzzles.

## Getting Started 
### Prerequisites
Make sure you have 8.0.406 version of the .NET;
### Installation
1. Open the zip file;
2. Create a new terminal;
3. Type these commands on the terminal:
```bash
cd FloodFill
```
```bash
dotnet run
```
Output:
```bash
Initial Grid:
2 3 0 0 1 
2 3 0 1 1 
2 0 2 2 1 
2 2 3 2 2 
2 2 2 2 1 
Choose any color (0-3) except for: 2
```

### Usage
The rule of the game is to fill the entire grid with one color. The game starts from the top left corner.
```bash
Initial Grid:
2 3 0 0 1 
2 3 0 1 1 
2 0 2 2 1 
2 2 3 2 2 
2 2 2 2 1 
Choose any color (0-3) except for: 2
3
Updated Grid:
3 3 0 0 1 
3 3 0 1 1 
3 0 3 3 1 
3 3 3 3 3 
3 3 3 3 1 
Choose any color (0-3) except for: 3
0
Updated Grid:
0 0 0 0 1 
0 0 0 1 1 
0 0 0 0 1 
0 0 0 0 0 
0 0 0 0 1 
Choose any color (0-3) except for: 0
1
Updated Grid:
1 1 1 1 1 
1 1 1 1 1 
1 1 1 1 1 
1 1 1 1 1 
1 1 1 1 1 
```

Also, make sure that you don't type text and a number that is beyond the limit:
```bash
Initial Grid:
3 1 2 3 2 
2 0 0 0 2 
3 0 1 1 1 
1 1 2 1 0 
0 0 2 2 0 
Choose any color (0-3) except for: 3
Two
Invalid input. Please enter a number between 0 and 3.
Choose any color (0-3) except for: 3
3
Invalid input. Please enter a number between 0 and 3.
Choose any color (0-3) except for: 3
4
Invalid input. Please enter a number between 0 and 3.
Choose any color (0-3) except for: 3
```

## Roadmap 
### Implemented Features
- Basic Flood Fill algorithm for grid-based problems.
- Command-line interface for user interaction.
- Input validation to handle invalid or out-of-range inputs.
- Dynamic grid updates after each user input.

### Planned Features
- Implement a graphical user interface (GUI) for better visualization.
- Tell a user how many moves it took for him/her to solve the problem.
- Add a "hint" feature to suggest optimal moves.
- Provide localization support for multiple languages.

## Contact
**Email:** cc231008@fhstp.ac.at
