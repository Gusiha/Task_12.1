
// arrays
int[] arr = new int[10];
FillArray(arr);

//structures
MyStruct[] myStructs = new MyStruct[10];
for (int i = 0; i < 10; i++)
{
    myStructs[i] = new MyStruct();
}

MyStruct2[] myStruct2s = new MyStruct2[10];
for (int i = 0; i < 10; i++)
{
    myStruct2s[i] = new MyStruct2();
}

MyStruct3[] myStruct3s;

#region BasicImplementation
//a
Console.WriteLine("A:");
PrintArray(arr);
Console.WriteLine($"\nMax = {FindMax(arr)}");

//b
Console.WriteLine("B:");
Console.WriteLine($"Max index = {FindIndexOfMax(arr)}");

//c
Console.WriteLine("C:");
PrintStruct(myStructs);
Console.WriteLine($"\nMax Y = {FindMaxY(myStructs)}");

//d
Console.WriteLine("D:");
PrintStruct2(myStruct2s);
myStruct3s = SortToStruct(myStruct2s);
Console.WriteLine();
PrintStruct3(myStruct3s);


void FillArray(int[] ints)
{
    Random random = new();

    for (int i = 0; i < ints.Length; i++)
    {
        ints[i] = random.Next(-10, 10);
    }
}

int FindMax(int[] ints)
{
    int max = int.MinValue;
    for (int i = 0; i < ints.Length; i++)
    {
        if (max < ints[i])
        {
            max = ints[i];
        }
    }
    return max;
}

int FindMaxY(MyStruct[] ints)
{
    int max = int.MinValue;
    for (int i = 0; i < ints.Length; i++)
    {
        if (max < ints[i].Y)
        {
            max = ints[i].Y;
        }
    }
    return max;
}

void PrintArray(int[] ints)
{
    for (int i = 0; i < ints.Length; i++)
    {
        Console.Write($" {ints[i]} ");
    }
}

void PrintStruct(MyStruct[] ints)
{
    for (int i = 0; i < ints.Length; i++)
    {
        Console.Write($" {ints[i].Y} ");
    }
}

void PrintStruct3(MyStruct3[] ints)
{
    for (int i = 0; i < ints.Length; i++)
    {
        Console.Write($" {ints[i].Y} ");
    }
}

void PrintStruct2(MyStruct2[] ints)
{
    for (int i = 0; i < ints.Length; i++)
    {
        Console.Write($" {ints[i].Y} ");
    }
}

int FindIndexOfMax(int[] ints)
{
    int max = int.MinValue;
    int index = 0;
    for (int i = 0; i < ints.Length; i++)
    {
        if (max < ints[i])
        {
            max = ints[i];
            index = i;
        }
    }
    return index;
}

MyStruct3[] SortToStruct(MyStruct2[] myStruct2)
{
    MyStruct3[] myStruct3 = new MyStruct3[myStruct2.Length];

    double temp = double.MinValue;

    for (int j = 0; j <= myStruct2.Length - 2; j++)
    {
        for (int i = 0; i <= myStruct2.Length - 2; i++)
        {
            if (myStruct2[i].Y > myStruct2[i + 1].Y)
            {
                temp = myStruct2[i + 1].Y;
                myStruct2[i + 1].Y = myStruct2[i].Y;
                myStruct2[i].Y = temp;
            }
        }
    }

    for (int i = 0; i < myStruct3.Length; i++)
    {
        myStruct3[i].X = myStruct2[i].X;
        myStruct3[i].Y = (int)myStruct2[i].Y;
    }

    return myStruct3;
}
#endregion





struct MyStruct
{
    public int X { get; set; }
    public int Y { get; set; }

    public MyStruct()
    {
        Random random1 = new Random();
        X = random1.Next(-10, 10);
        Y = random1.Next(-10, 10);
    }

}

struct MyStruct2
{
    public int X { get; set; }
    public double Y { get; set; }

    public MyStruct2()
    {
        Random random1 = new Random();
        X = random1.Next(-10, 10);
        Y = random1.Next(-10, 10);
    }


}

struct MyStruct3
{
    public double X { get; set; }
    public int Y { get; set; }

    public MyStruct3()
    {
        Random random1 = new Random();
        X = random1.Next(-10, 10);
        Y = random1.Next(-10, 10);
    }


}


