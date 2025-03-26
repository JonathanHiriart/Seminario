// inicio de clase 3 
// los var son de tipo anonimo es decir que no tienen tipos 
var x = new {nombre= "juan", edad = 20};
Console.WriteLine(x.GetType());
dynamic d = "hola";
Console.WriteLine(d.GetType());
d = 12;
Console.WriteLine(d.GetType());