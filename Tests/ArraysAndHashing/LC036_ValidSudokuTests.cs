using NeetCode.Solutions.ArraysAndHashing;

namespace NeetCode.Tests.ArraysAndHashing;

[TestClass]
public class LC036_ValidSudokuTests
{
    [TestMethod]
    public void ValidBoard_ReturnsTrue()
    {
        var board = GetBoard();

        var result = IsValidSudoku(board);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void ColumnInvalidNumber_ReturnsFalse()
    {
        var board = GetBoard();
        board[0][0] = '8';

        var result = IsValidSudoku(board);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void RowInvalidNumber_ReturnsFalse()
    {
        var board = GetBoard();
        board[4][3] = '3';

        var result = IsValidSudoku(board);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void BoxInvalidNumber_ReturnsFalse()
    {
        var board = GetBoard();
        board[6][6] = '5';

        var result = IsValidSudoku(board);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void MultipleInvalidNumbers_ReturnsFalse()
    {
        var board = GetBoard();
        board[7][3] = '1';
        board[2][7] = '8';

        var result = IsValidSudoku(board);

        Assert.IsFalse(result);
    }

    private static bool IsValidSudoku(char[][] board)
    {
        var @object = new LC036_ValidSudoku();
        var result = @object.IsValidSudoku(board);
        return result;
    }

    private char[][] GetBoard()
    {
        return new char[9][] {
            new char[9]{'5','3','.','.','7','.','.','.','.'},
            new char[9]{'6','.','.','1','9','5','.','.','.'},
            new char[9]{'.','9','8','.','.','.','.','6','.'},
            new char[9]{'8','.','.','.','6','.','.','.','3'},
            new char[9]{'4','.','.','8','.','3','.','.','1'},
            new char[9]{'7','.','.','.','2','.','.','.','6'},
            new char[9]{'.','6','.','.','.','.','2','8','.'},
            new char[9]{'.','.','.','4','1','9','.','.','5'},
            new char[9]{'.','.','.','.','8','.','.','7','9'}
        };
    }
}