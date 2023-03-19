public class Example
{
    public static void Main()
    {
        string matrixValue;
        string ceroPosition;
        int number = 0;
        int i;
        int j;

        Console.WriteLine("Insert value of matrix:");
        matrixValue = Console.ReadLine();

        int newValue = Int32.Parse(matrixValue);

        string[,] matrix = new string[newValue, newValue];

        Console.WriteLine("Insert the cero position:");
        ceroPosition = Console.ReadLine();

        int realCeroPositon = Int32.Parse(ceroPosition);

        string oldPathString = "Put here your old path string";
        string newPathString = "Put here your new path string";
        string imageTypeFile = "Here your image type file";

        for (i = 0; i < newValue; i++)
        {
            for (j = 0; j < newValue; j++)
            {
                number++;
                string oldPath = @"" + oldPathString + (number).ToString() + ".png";
                Console.WriteLine(oldPath);
                matrix[i, j] = "uniMap_" + (j - realCeroPositon + 1).ToString() + "_" + i.ToString() + imageTypeFile;
                string newPath = @"" + newPathString + (j - realCeroPositon + 1).ToString() + "_" + i.ToString() + imageTypeFile;
                Console.WriteLine(newPath);
                Console.WriteLine(matrix[i, j]);
                File.Move(oldPath, newPath);
            }
        }
    }
}
