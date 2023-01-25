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


