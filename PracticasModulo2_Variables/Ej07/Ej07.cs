/*
 * Environment.NewLine hace lo mismo que \r\n, es el método habitual de Windows y,
 * para este ejemplo nos sirve puesto que no es una secuencia de escape
 */
string string1 = "Hola" + Environment.NewLine + "Mundo";
Console.WriteLine(string1);