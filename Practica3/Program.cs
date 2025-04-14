// inicio de clase 3 
// los var son de tipo anonimo es decir que no tienen tipos 
/*
string marca = "Ford";
int modelo = 2000;
string st = string.Format("Es un {0} año {1}", marca, modelo);
Console.WriteLine(st);
*/
// string de formata compuesto 

string marca = "Ford";
int modelo = 2000;
string st = $"Es un {marca} año {modelo}";
Console.WriteLine(st);

// string en cadena interpolada 


/*
double r = 2.417;
Console.WriteLine($"valor = {r:0.000} ");
*/
