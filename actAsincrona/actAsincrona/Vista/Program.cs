// See https://aka.ms/new-console-template for more information
using actAsincrona.Entidades;
using actAsincrona.Negocio;

Console.WriteLine("Introduzca un texto");
String texto;
texto = Console.ReadLine();

Texto txt = new Texto();
TextoLogica txtL = new TextoLogica();

txt.setTexto(texto); 

int contador = txtL.contador(txt.getTexto());

Console.WriteLine("El número de letras que hay en el texto es: " + contador);
Console.Read();


