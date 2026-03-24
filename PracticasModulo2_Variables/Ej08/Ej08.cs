/*
 * Con la palabra registrada "unchecked" podemos almacenar una variable, aunque no con el valor
 * introducido, ya que, si usamos unchecked, es porque hay un overflow del tipo.
 *
 * Por otro lado, con la conversión explicita realizada en el int, se guarda la variable con el
 * overflow automaticamente, esto es así debido a que no es un literal el que causa el overflow,
 * es el valor de otra variable de tamaño superior
 */
long l = unchecked((long)12345678901234567890);
int i = (int) l;

Console.WriteLine(l);
Console.WriteLine(i);