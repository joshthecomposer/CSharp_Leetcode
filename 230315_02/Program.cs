//https://www.codewars.com/kata/5a905c2157c562994900009d/train/csharp

int[] ProductArray(int[] input)
{
    int m = 1;
    int[] output = new int[input.Length];
    bool skip = false;
    for (int i = 0; i < input.Length; i++)
    {

        for (int j = 0; j < input.Length; j++)
        {
            if (j == i)
            {
                skip = true;
                continue;
            }
            m *= input[j];
        }

        output[i] = m;
        m = 1;

    }
    return output;
}

int[] input1 = ProductArray(new int[] { 3, 27, 4, 2 });
int[] input2 = ProductArray(new int[] {13, 10, 5, 2, 9});
int[] input3 = ProductArray(new int[] {16, 17, 4, 3, 5, 2});

foreach (int i in input3)
{
    Console.WriteLine(i);
}