/*
 * Aunque el resultado se almacene en un double, si se dividen 2 enteros, el resultado será un entero,
 * aunque deba tener cifras decimales. Para evitar esto debemos indicar que alguno de los valores es de
 * un tipo en coma flotante (float, double)
 */
int i = 5; 
double d = i/2D; 
Console.WriteLine(d);