using Task_12._1;


#region Assignment and Initialization
int[] arr = new int[10];
FillArray(arr);

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

#endregion

#region Common Implementation
//a
Console.WriteLine("ОБЫЧНАЯ РЕАЛИЗАЦИЯ:");
Console.WriteLine("A:");
PrintArray(arr);
Console.WriteLine($"Max = {FindMax(arr)}");

//b
Console.WriteLine("B:");
Console.WriteLine($"Max index = {FindIndexOfMax(arr)}");

//c
Console.WriteLine("C:");
PrintStruct(myStructs);
Console.WriteLine($"\nMax Y = {FindMaxY(myStructs)}");

//d
Console.WriteLine("D:");
Console.Write("До сортировки: ");
PrintStruct2(myStruct2s);

myStruct3s = SortToStruct(myStruct2s);
Console.WriteLine();
Console.Write("После сортировки: ");
PrintStruct3(myStruct3s);
#endregion

#region ArrayMethods
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


void PrintArray(int[] ints)
{
    for (int i = 0; i < ints.Length; i++)
    {
        Console.Write($" {ints[i]} ");
    }
    Console.WriteLine();
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
#endregion

#region StructureMethods
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

#region Change to default
FillArray(arr);
Array.Clear(myStruct3s);
Array.Clear(myStruct2s);
Array.Clear(myStructs);


for (int i = 0; i < 10; i++)
{
    myStructs[i] = new();
    myStruct2s[i] = new();
    myStruct3s[i] = new();
}
#endregion

#region LINQ Implementation
Console.WriteLine("\n\nLINQ РЕАЛИЗАЦИЯ:");

Console.WriteLine("A:");
PrintArray(arr);
Console.WriteLine($"Max = {arr.Max()}");

//b
Console.WriteLine("B:");
Console.WriteLine($"Index of Max = {Array.IndexOf(arr, arr.Max())}");

//c
int sortY = myStructs.Max(x => x.Y);
Console.WriteLine("C:");
PrintStruct(myStructs);
Console.WriteLine($"\nMax по Y : {sortY}");


//d
Console.WriteLine("D:");

MyStruct2[] last = myStruct2s.OrderBy(x => x.Y).Select(x => x).Cast<MyStruct2>().ToArray();

MyStruct3[] hello = Array.ConvertAll(last, new Converter<MyStruct2, MyStruct3>(toMyStruct3));


Console.WriteLine("myStruct2s: ");
foreach (var item in last)
{
    Console.Write($"{item.Y} ");
}
Console.WriteLine("");
Console.WriteLine("myStruct3s: ");

foreach (var item in hello)
{
    Console.Write($"{item.Y} ");
}


MyStruct3 toMyStruct3(MyStruct2 v)
{
    MyStruct3 myStruct3 = new MyStruct3();
    myStruct3.X = v.X;
    myStruct3.Y = (int)v.Y;
    return myStruct3;
}



#endregion








