﻿// See https://aka.ms/new-console-template for more information
using HelloWorld10;

int r = 1234567;
var tp = r.GetType().FullName;


var revers = new string(r.ToString().ToArray().Reverse().ToArray());


var a = new MyClass();
a.Person = $"3424{r}234{revers}";
a.MyProperty = 10;
 //HelloWorld10.MyClass.Student = "254545";
double v = 10;

var c =  a.Add(new double[] { 10, 15, 16, 17, 23 });

c = a.Add(10, 15, 16, 17, 23,true,"Ivan");
var b = MyClass.Name;


var bigClass = new BigClass();


//for (int i=0;i<10;i++)
Console.WriteLine("Hello, World!");
