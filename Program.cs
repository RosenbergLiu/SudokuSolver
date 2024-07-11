using System.Text.Json;
using System.Text.RegularExpressions;

int[][]? inputBoard = TakeInput();
int[][] outputBoard = SolveSudoku(inputBoard);
DisplayBoard(outputBoard);
return;



#region Solver methods

int[][] SolveSudoku(int[][] board) {
    var solved = false;
    while (!solved) {
        solved = Backtrack(board, 0);
    }
    
    return board;
}

bool Backtrack(int[][] board, int index) {
    if (index == 81) return true; // Solved when index reaches the end of the last cell

    int currentRow = index / 9;
    int currentColumn = index % 9;

    if (board[currentColumn][currentRow] != 0) {
        return Backtrack(board, index + 1); // Skip already filled cells
    }

    for (int candidate = 1; candidate <= 9; candidate++)
    {
        if (!CanPlaceValue(board, candidate, currentColumn, currentRow)) continue; // Check if the candidate can be placed
        
        // Place the candidate and recursively solve
        board[currentColumn][currentRow] = candidate;
        if (Backtrack(board, index + 1)) {
            return true;
        }
        board[currentColumn][currentRow] = 0; // Undo the move
    }
    return false; // Trigger backtracking if no number can be placed
}

bool CanPlaceValue(int[][] board, int value, int colIndex, int rowIndex) {
    // Check the current row for conflicts
    for (int i = 0; i < 9; i++) {
        if (board[colIndex][i] == value) {
            return false;
        }
    }
    // Check the current column for conflicts
    for (int i = 0; i < 9; i++) {
        if (board[i][rowIndex] == value) {
            return false;
        }
    }
    // Check the current box for conflicts
    int gridRowStart = (rowIndex / 3) * 3;
    int gridColumnStart = (colIndex / 3) * 3;
    for (int i = gridColumnStart; i < gridColumnStart + 3; i++) {
        for (int j = gridRowStart; j < gridRowStart + 3; j++) {
            if (board[i][j] == value) {
                return false; // Conflict found
            }
        }
    }
    return true; // No conflicts, value can be safely placed
}

#endregion












#region UI related methods

int[][]? TakeInput()
{
    bool isValidInput = false;
    int[][]? validBoard = new int[9][];
    
    while (!isValidInput)
    {
        Console.WriteLine("================================");
        Console.WriteLine("Please enter the Sudoku board as a single line JSON string or drag a .json file here:");
        var input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("No input provided.");
            continue;
        }
        input = input.Trim();

        string jsonInput;

        var filePathRegex = new Regex(@"^([a-zA-Z]:\\)?([^\\/:*?<>|]+\\)*([^\\/:*?<>|]+)\.json$|^(\/)?([^\/:*?<>|]+\/)*([^\/:*?<>|]+)\.json$", RegexOptions.IgnoreCase);
        if (filePathRegex.IsMatch(input) && File.Exists(input))
        {
            jsonInput = File.ReadAllText(input);
        }
        else
        {
            jsonInput = input;
        }

        try
        {
            validBoard = JsonSerializer.Deserialize<int[][]>(jsonInput);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Invalid json content.");
            continue;
        }

        if (validBoard == null)
        {
            Console.WriteLine("Invalid board format.");
            continue;
        }
        isValidInput = true;
    }

    return validBoard;
}

void DisplayBoard(int[][] board)
{
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Solved Sudoku:");
    for (int i = 0; i < 9; i++)
    {
        if (i % 3 == 0 && i != 0)
        {
            Console.WriteLine("------ ------- -------");
        }

        for (int j = 0; j < 9; j++)
        {
            if (j % 3 == 0 && j != 0)
            {
                Console.Write("| ");
            }

            Console.Write(board[i][j] + " ");
        }

        Console.WriteLine();
    }
}

#endregion
