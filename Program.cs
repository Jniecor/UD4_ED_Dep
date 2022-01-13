using System;
class ArrayExample
{
    static void Main()
    {
        //Define un array de carateres llamado letters.
        char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };
        //Define una etiqueta llamada name.
        string name = "";
        //Define 10 posiciones la cual se llama "a".
        int[] a = new int[10];
        //Define el bucle for con la variable "i" la es un tipo entero y empieza por 0
        //El bucle se sigue haciendo hasta que la "i" sea menor a la longitud de letters.
        //Y a partir de la segunda vuelta a la "i" se le suma 1.
        for (int i = 0; i < letters.Length; i++)
        {
            name += letters[i]; //Define name como la letra la cual esta en la posición que dicta la "i"
            a[i] = i + 1; //Se suma uno a la posición
            SendMessage(name, a[i]); //Emite el mensaje con las variables ya cambiadas
        }
        Console.ReadKey();
    }
    static void SendMessage(string name, int msg)
    {
        //Se escribe el mensaje con las variables actualizadas
        Console.WriteLine("Hello, " + name + "! Count to " + msg); 
    }
}
