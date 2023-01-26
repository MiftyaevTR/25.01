// Recursiya string 1-10
/*
string NumbersFor(int a, int b)
{
    string result=string.Empty;
    for (int i=a; i<=b; i++)
        result+=$"{i} ";
    return result;
}

Console.Write(NumbersFor(1,10));
Console.WriteLine();

string NumbersRec(int a, int b)
{
    if (a<=b) return $"{a} " + NumbersRec(a+1, b);
    else return string.Empty;
}

Console.Write(NumbersRec(1,20));
*/
// Factorial
/*
int Factorial( int a)
{
    int res =1;
    for (int i=1; i<a; i++) res*=i;
    return res;
}

Console.WriteLine(Factorial(10));
Console.WriteLine();

int FactorialRec(int n)
{
    if (n==1) return 1;
    else return n* FactorialRec(n-1);
}
Console.WriteLine(FactorialRec(15));
*/
//  word
/*
int n=1;
void FindWords( string alf, char[] word, int lenght=0)
{
    if (lenght==word.Length) 
    {     Console.WriteLine ($"{n++} {new String(word)}"); 
         return;
    }
    for (int i=0; i<alf.Length; i++)
    {
        word[lenght]=alf[i];
        FindWords(alf, word, lenght+1);
    }
}

FindWords("qwer", new char[4]);
*/
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
/*
int[,] CreateRandom2dArray ()
{
    Console.WriteLine("Input a numbers of rows: ");
    int rows =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a numbers of columns: ");
    int columns =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min of element: ");
    int min =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max of element: ");
    int max =Convert.ToInt32(Console.ReadLine());

    int[,] array=new int[rows,columns];

    for (int i=0; i<rows; i++)
        for (int j=0; j<columns; j++)
            array[i,j]= new Random().Next(min, max+1);
    return array;
}

void Show2dArray (int[,] array)
{
     for (int i=0; i<array.GetLength(0); i++)
     {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");
        Console.WriteLine();
     }
     Console.WriteLine();
}

void ChnageRows(int[,] array, int row1, int row2)
{
    if (row1>0 && row1<array.GetLength(0) &&
        row2>0 && row2<array.GetLength(0) &&
        row1 != row2)
    for (int j=0; j<array.GetLength(1); j++)
    {
        int temp = array[row1,j];
        array[row1,j]=array[row2,j];
        array[row2,j]=temp;
    }
    return array;
}

int[,] myArray= CreateRandom2dArray();
Show2dArray(myArray);

Console.WriteLine("Pls inter a number of the first row: ");
int r1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Pls inter a number of the second row: ");
int r2=Convert.ToInt32(Console.ReadLine());

ChnageRows(myArray,r1,r2);
Show2dArray(myArray);
*/
//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
/*
int[,] CreateRandom2dArray ()
{
    Console.WriteLine("Input a numbers of rows: ");
    int rows =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a numbers of columns: ");
    int columns =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min of element: ");
    int min =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max of element: ");
    int max =Convert.ToInt32(Console.ReadLine());

    int[,] array=new int[rows,columns];

    for (int i=0; i<rows; i++)
        for (int j=0; j<columns; j++)
            array[i,j]= new Random().Next(min, max+1);
    return array;
}

void Show2dArray (int[,] array)
{
     for (int i=0; i<array.GetLength(0); i++)
     {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");
        Console.WriteLine();
     }
     Console.WriteLine();
}

void ChnageRowsColumns (int [,] array)
{
    if(array.GetLength(0)==array.GetLength(1))
     for (int i=0; i<array.GetLength(0); i++)
     {
        for (int j=i+1; j<array.GetLength(1); j++)
        {
           int temp=array[i,j];
           array[i,j]=array[j,i];
           array[j,i]=temp;
        }
     }
}

int[,] myArray= CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
ChnageRowsColumns(myArray);
Show2dArray(myArray);
*/
// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
/*
int[,] CreateRandom2dArray ()
{
    Console.WriteLine("Input a numbers of rows: ");
    int rows =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a numbers of columns: ");
    int columns =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min of element: ");
    int min =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max of element: ");
    int max =Convert.ToInt32(Console.ReadLine());

    int[,] array=new int[rows,columns];

    for (int i=0; i<rows; i++)
        for (int j=0; j<columns; j++)
            array[i,j]= new Random().Next(min, max+1);
    return array;
}

void Show2dArray (int[,] array)
{
     for (int i=0; i<array.GetLength(0); i++)
     {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write($"{array[i,j]} ");
        Console.WriteLine();
     }
     Console.WriteLine();
}

int[] MinElement (int[,] array)
{   
    int mini=0;
    int minj=0;
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
            if (array[i,j]<array[mini,minj]) 
            {
                mini=i;
                minj=j;   
            }
    }
    int[] indexes = {mini, minj};
    return indexes;
}

int[,] ChangedArray (int [,] array, int[] indexes)
{
    int[,] massiv= new int[array.GetLength(0)-1, array.GetLength(1)-1];
    for (int i=0, x=0; i<array.GetLength(0); i++,x++)
    {
        if (indexes[0]==i) 
        {
            x--;
            continue;
        }
        else
            for (int j=0, y=0; j<array.GetLength(1); j++,y++)
                if (indexes[1]==j)
                {
                    y--;
                    continue;
                }
                else
                    massiv[x,y]=array[i,j];
    }
    return massiv;
}

int[,] myArray= CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();

int[] indexes=MinElement(myArray);
Show2dArray(ChangedArray(myArray,indexes));
*/

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2dArray ()
{
    Console.WriteLine("Input a numbers of rows: ");
    int rows =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a numbers of columns: ");
    int columns =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min of element: ");
    int min =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max of element: ");
    int max =Convert.ToInt32(Console.ReadLine());

    int[,] array=new int[rows,columns];

    for (int i=0; i<rows; i++)
        for (int j=0; j<columns; j++)
            array[i,j]= new Random().Next(min, max+1);
    return array;
}

void Show2dArray (int[,] array)
{
     for (int i=0; i<array.GetLength(0); i++)
     {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");
        Console.WriteLine();
     }
     Console.WriteLine();
}

void SortRows (int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j>array.GetLength(1)-1; j++)
        {
            int minposition=j;
            for (int k=j+1; k<array.GetLength(1); k++)
            {
                if (array[i,k]<array[i,minposition]) minposition=k;
            }
            int tempor=array[i,j];
            array[i,j]=array[i,minposition];
            array[i,minposition]=tempor;
        }
    }
}

int[,] myArray= CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine("Sorted array:");
SortRows(myArray);
Show2dArray(myArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray ()
{
    Console.WriteLine("Input a numbers of rows: ");
    int rows =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a numbers of columns: ");
    int columns =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min of element: ");
    int min =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max of element: ");
    int max =Convert.ToInt32(Console.ReadLine());

    int[,] array=new int[rows,columns];

    for (int i=0; i<rows; i++)
        for (int j=0; j<columns; j++)
            array[i,j]= new Random().Next(min, max+1);
    return array;
}

void Show2dArray (int[,] array)
{
     for (int i=0; i<array.GetLength(0); i++)
     {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write($"{array[i,j]} ");
        Console.WriteLine();
     }
     Console.WriteLine();
}

int [] RowsSum (int[,] array)
{   
    
    int[] sumArray=new int[array.GetLength(0)];
    if (array.GetLength(0)!=array.GetLength(1))
    for (int i=0; i<array.GetLength(0); i++)
    {
        int sum=0;
        for (int j=0; j<array.GetLength(1); j++) 
        {
            sum+=array[i,j];
        }     
        sumArray[i]=sum;
    }
    else Console.WriteLine("Просьба задать прямоугольный двумерный массив");
    return sumArray;
}

void ShowArray (int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int IndexMinElement (int[] array)
{
    int minposition=0;
    for (int i=0; i<array.Length; i++)
        if (array[i]<array[minposition]) minposition=i;
    return minposition;
}

int[,] myArray= CreateRandom2dArray();
Show2dArray(myArray);
int[] res = RowsSum(myArray);
ShowArray(res);
int result =IndexMinElement(res)+1;
Console.WriteLine("The row's number is: "+ result);
*/
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateRandom2dArray ()
{
    Console.WriteLine("Input a size of matrix: ");
    int rows =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min of element: ");
    int min =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max of element: ");
    int max =Convert.ToInt32(Console.ReadLine());

    int[,] array=new int[rows,rows];

    for (int i=0; i<rows; i++)
        for (int j=0; j<rows; j++)
            array[i,j]= new Random().Next(min, max+1);
    return array;
}

void Show2dArray (int[,] array)
{
     for (int i=0; i<array.GetLength(0); i++)
     {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write($"{array[i,j]} ");
        Console.WriteLine();
     }
     Console.WriteLine();
}

int[,] Prod2dArrays (int [,] fArray, int[,] sArray)
{
    int[,] massiv= new int[fArray.GetLength(0), fArray.GetLength(1)];
    for (int i=0; i<fArray.GetLength(0); i++)
            for (int j=0; j<fArray.GetLength(1); j++)
                    for (int k=0; k<fArray.GetLength(0); k++)    
                        massiv[i,j] += fArray[i,k] * sArray[k,j];
    return massiv;
}

int[,] firstArray= CreateRandom2dArray();
int[,] secondArray= CreateRandom2dArray();
Show2dArray(firstArray);
Show2dArray(secondArray);
int[,] result=Prod2dArrays(firstArray,secondArray);
Show2dArray(result);
*/

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] CreateRandom3dArray (int max, int min)
{
    Console.WriteLine("Input a numbers of rows: ");
    int layers =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a numbers of columns: ");
    int columns =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a numbers of layers: ");
    int rows=Convert.ToInt32(Console.ReadLine());

    int[,,] array=new int[rows,columns,layers];

    for (int i=0; i<rows; i++)
        for (int j=0; j<columns; j++)
            for (int k=0; k<layers; k++)
                    {
                        array[i,j,k]= new Random().Next(min, max+1);
                    }
    return array;
}

void UniqueElements (int[,,] array, int max, int min)
{
    int unique=array[0,0,0];
    for (int i=0; i<array.GetLength(0); i++)
        for (int j=0; j<array.GetLength(1); j++)
            for (int k=1; k<array.GetLength(2); k++)
            {
                if (array[i,j,k]==unique) 
                {
                    array[i,j,k]= new Random().Next(min, max+1);
                    unique=array[i,j,k];
                }
            }
}

void Show3dArray (int[,,] array)
{
     for (int i=0; i<array.GetLength(0); i++)
     {
        for (int j=0; j<array.GetLength(1); j++)
            {
                for (int k=0; k<array.GetLength(2); k++)
                        Console.Write($"{array[i,j,k]} ({i},{j},{k}) ");
                Console.WriteLine();
            }   
        Console.WriteLine();
     }
     Console.WriteLine();
}

Console.WriteLine("Input a min of element: ");
int min =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max of element: ");
int max =Convert.ToInt32(Console.ReadLine());

int[,,] myArray= CreateRandom3dArray(max,min);
UniqueElements(myArray,max,min);
Show3dArray(myArray);
*/
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
int[,] Spiral2dArray ()
{
    int[,] array = new int[4, 4];
    int i = 0;
    int j = 0;
    for (int el=1; el <= 16; el++)
    {
        array[i, j] = el;
        if (i <= j + 1 && i + j < 3) j++;
        else if (i < j && i + j >= 3) i++;
        else if (i >= j && i + j > 3) j--;
        else i--;
    }
    return array;
}

void Show2dArray (int[,] array)
{
     for (int i=0; i<array.GetLength(0); i++)
     {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write($"{array[i,j]} ");
        Console.WriteLine();
     }
     Console.WriteLine();
}

int[,] myArray= Spiral2dArray();
Show2dArray(myArray);
*/






















































