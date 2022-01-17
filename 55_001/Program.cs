// 

int[,] CreateIntegerArray(int rowsNumber, int colsNumber)
{
    int[,] arrayToReturn = new int[rowsNumber, colsNumber];
    for (int row = 0; row < rowsNumber; row++)
    {
        for (int col = 0; col < colsNumber; col++)
        {
            arrayToReturn[row,col] = new Random().Next(-row, row);
        }
    }
    return arrayToReturn;
}


