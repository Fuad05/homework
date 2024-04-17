// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;

var km = 3;
var bz = 60;
var ms = 10;
if (ms * km < bz)
{
    Console.WriteLine("gede biler");
}
else
{
    Console.WriteLine("Gede bilmez");
}



//***********************************************************



var s = 20;
var m = 30;
var l = 40;
var min=0;
if (s < m&& s<l )
{
    min = m + l;
    Console.WriteLine(min);
}
if(s<m&& l<s)
{
    min = s + m;
    Console.WriteLine(min); 
}
if(m<s&&s<l)
{
    min = s + l;
    Console.WriteLine(min);
}



//************************************************************



var a = 10;
var b = 20;
var c = 30;
var d = 40;
var hasil = 1;
hasil = a * b * c * d;
Console.WriteLine(hasil);



//***********************************************************



var a = 10;
var b = 20;
var c = 30;
if(a > b && a > c)
{
    Console.WriteLine(a);
}
if(b > c && b > a)
{
    Console.WriteLine(b);
}
if(c > a && c > b)
{
    Console.WriteLine(c);
}
