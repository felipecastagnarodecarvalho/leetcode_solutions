// Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:
//     Each row must contain the digits 1-9 without repetition.
//     Each column must contain the digits 1-9 without repetition.
//     Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
// Note:
//     A Sudoku board (partially filled) could be valid but is not necessarily solvable.
//     Only the filled cells need to be validated according to the mentioned rules.
public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> seen = new HashSet<string>();

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                char number = board[i][j];

                if (number != '.')
                {
                    if (!seen.Add(number + " in row " + i) ||
                        !seen.Add(number + " in column " + j) ||
                        !seen.Add(number + " in block " + i / 3 + "-" + j / 3))
                    {
                        return false;
                    }
                }
            }
        }

        return true;
    }
}