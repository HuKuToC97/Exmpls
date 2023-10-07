int Max(int arg1, int arg2,int arg3)
{
    int result = arg1;
    if(arg2> result ) result = arg2;
    if(arg3> result ) result = arg3;
    return result;
}

int a1 = new Random().Next(1, 5000);
System.Console.Write(a1 + ", ");
int a2 = new Random().Next(1, 5);
System.Console.Write(a2 + ", ");
int a3 = new Random().Next(1, 5);
System.Console.Write(a3 + ", ");
int b1 = new Random().Next(1, 5);
System.Console.Write(b1 + ", ");
int b2 = new Random().Next(1, 5);
System.Console.Write(b2 + ", ");
int b3 = new Random().Next(1, 5);
System.Console.Write(b3 + ", ");
int c1 = new Random().Next(1, 5);
System.Console.Write(c1 + ", ");
int c2 = new Random().Next(1, 5);
System.Console.Write(c2 + ", ");
int c3 = new Random().Next(1, 3000);
System.Console.WriteLine(c3 + ", ");

// int max1 = Max (a1, b1, c1);
// int max2 = Max (a2, b2, c2);
// int max3 = Max (a3, b3, c3);
// int max = Max (max1, max2, max3);
int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max( Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));


System.Console.WriteLine(max);
