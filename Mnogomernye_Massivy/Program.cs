/*string[,] strings = new string[3, 4]
{
    {"a", "b", "c", "d"},
    {"e", "f", "g", "h"},
    {"i", "j", "k", "l"},
};

int[,,,] nums = new int[2, 3, 4, 5]
{
    {
        {
            {1,2,3,4,5},
            {1,2,3,4,5},
            {1,2,3,4,5},
            {1,2,3,4,5}
        },
        {
            {1,2,3,4,5},
            {1,2,3,4,5},
            {1,2,3,4,5},
            {1,2,3,4,5}
        },
        {
            {1,2,3,4,5},
            {1,2,3,4,5},
            {1,2,3,4,5},
            {1,2,3,4,5}
        },
    },
        {
        {
            {1,2,3,4,5},
            {1,2,3,4,5},
            {1,2,3,4,5},
            {1,2,3,4,5}
        },
        {
            {1,2,3,4,5},
            {1,2,3,4,5},
            {1,2,3,4,5},
            {1,2,3,4,5}
        },
        {
            {1,2,3,4,5},
            {1,2,3,4,5},
            {1,2,3,4,5},
            {1,2,3,4,5}
        },
    }

};
*/
/*Console.WriteLine("{0}, {1}", strings.GetLength(0), strings.GetLength(1));
for (int i = 0; i < strings.GetLength(0); i++)
{
    for (int j = 0; j < strings.GetLength(1); j++) 
        Console.Write($"{strings[i,j]} ");

    Console.WriteLine();
}
*/

/*for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        for (int k = 0; k < nums.GetLength(2); k++)
        {
            for (int h = 0; h < nums.GetLength(3); h++)
            {
                string tab = "";
                for (int w = 0; w < i + j + k + h; w++)
                    tab += " ";
                Console.WriteLine($"{tab}{nums[i,j,k,h]}");
            }
        }
    }
}*/
string[,] array_new = GetData("D://Products.csv");
Print(array_new);
string[,] GetData(string way)
{
    string[] lines = File.ReadAllLines(way);

    string[,] result = new string[lines.Length, 3];

    for (int i = 1; i < lines.Length; i++)
    {
        string[] fields = lines[i].Split(';');
        if (fields.Length != 3) continue;
        for (int j = 0; j < fields.Length; j++)
        {
            result[i, j] = fields[j];
        }
    }
    return result;
}

void Print(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t\t");
        Console.WriteLine();
    }
}