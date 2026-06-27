# String en C#

## ¿String es un tipo por valor o un tipo por referencia?

String es un tipo por referencia. Internamente es la clase System.String y sus variables almacenan una referencia a un objeto en el heap, no el valor directamente.

Aunque se comporta de forma similar a un tipo por valor porque es inmutable: cualquier operación que modifique un string crea un nuevo objeto en memoria en lugar de modificar el existente.

Ejemplo:
    string a = "Hola";
    string b = a;
    a = "Mundo";
    Console.WriteLine(b); // Salida: Hola


## ¿Qué secuencias de escape tiene el tipo string?

\'    Comilla simple
\"    Comilla doble
\\    Barra invertida
\0    Carácter nulo
\a    Alerta (bell)
\b    Retroceso (backspace)
\f    Avance de página
\n    Nueva línea
\r    Retorno de carro
\t    Tabulación horizontal
\v    Tabulación vertical
\uXXXX      Carácter Unicode (4 dígitos hex)
\UXXXXXXXX  Carácter Unicode (8 dígitos hex)
\xXX        Carácter hexadecimal (longitud variable)

Ejemplo:
    string ruta    = "C:\\Users\\nombre";
    string mensaje = "Línea 1\nLínea 2";
    string acento  = "\u00C1ngel"; // "Ángel"


## ¿Qué sucede cuando se usa @ y $ antes de una cadena?

--- Prefijo @ (verbatim string) ---

Desactiva el procesamiento de secuencias de escape. El texto se toma exactamente como está escrito. También permite cadenas multilínea. Para incluir comillas dobles se usan dos comillas seguidas ("").

Ejemplo:
    string ruta  = @"C:\Users\nombre\Documentos"; // sin necesidad de \\
    string multi = @"Primera línea
Segunda línea
Tercera línea";
    string cita  = @"Ella dijo ""hola"".";


--- Prefijo $ (interpolación) ---

Permite insertar expresiones de C# directamente dentro de la cadena usando llaves {}. El valor se evalúa en tiempo de ejecución.

Ejemplo:
    string nombre = "Ana";
    int edad = 30;
    string saludo = $"Me llamo {nombre} y tengo {edad} años.";
    // Resultado: "Me llamo Ana y tengo 30 años."


--- Combinación $@ o @$ ---

Combina ambos prefijos: cadena textual con interpolación al mismo tiempo.

Ejemplo:
    string usuario = "Carlos";
    string ruta = $@"C:\Users\{usuario}\Documentos";
    // Resultado: "C:\Users\Carlos\Documentos"