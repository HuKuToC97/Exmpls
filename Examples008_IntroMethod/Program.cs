﻿int a1 = new Random().Next(1, 5);
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
int c3 = new Random().Next(1, 5);
System.Console.WriteLine(c3 + ", ");

int max = a1;
if(b1> max ) max = b1;
if(c1> max ) max = c1;

if(a2> max ) max = a2;
if(b2> max ) max = b2;
if(c2> max ) max = c2;

if(a3> max ) max = a3;
if(b3> max ) max = b3;
if(c3> max ) max = c3;

System.Console.WriteLine(max);
