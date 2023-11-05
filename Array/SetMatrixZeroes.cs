
namespace DataStructure.Array
{
    internal class SetMatrixZeroes
    {
        public void SetZeroes(int[][] matrix)
        {

            int rows = matrix.Length;
            int cols = matrix[0].Length;

            var rowArray = new int[rows];
            var colArray = new int[cols];

            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < cols; j++)
                {

                    if (matrix[i][j] == 0)
                    {
                        rowArray[i] = 1;
                        colArray[j] = 1;
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < cols; j++)
                {

                    if (rowArray[i] == 1 || colArray[j] == 1)
                    {

                        matrix[i][j] = 0;
                    }
                }
            }

        }
    }
}
