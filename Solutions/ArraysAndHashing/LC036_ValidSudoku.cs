namespace NeetCode.Solutions.ArraysAndHashing;

public class LC036_ValidSudoku
{
    public bool IsValidSudoku(char[][] board)
    {
        return IsValidSudoku_I(board);
    }

    private static bool IsValidSudoku_I(char[][] board)
    {
        var rowNumbers = new HashSet<char>(9);
        var colNumbers = new HashSet<char>(9);
        var boxNumbers = new HashSet<char>(9);

        for (var i = 0; i < board.Length; i++)
        {
            rowNumbers.Clear();
            colNumbers.Clear();
            boxNumbers.Clear();

            for (var j = 0; j < board[i].Length; j++)
            {
                if (board[i][j] != '.' && !rowNumbers.Add(board[i][j]))
                    return false;

                if (board[j][i] != '.' && !colNumbers.Add(board[j][i]))
                    return false;

                var iBox = j / 3 + i / 3 * 3;
                var jBox = j % 3 + i % 3 * 3;
                if (board[iBox][jBox] != '.' && !boxNumbers.Add(board[iBox][jBox]))
                    return false;
            }
        }

        return true;
    }
}