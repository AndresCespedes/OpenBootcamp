using System.Collections.Specialized;

class Sesion2
{
    static void Main()
    {
        //Ejercicio 1

        Console.WriteLine("----- Ejercicio 1 ------");
        string name = "Julian";
        string lastName = "Alvarez";
        int age = 23;
        bool knowProgramming = true;

        string message = $"El nombre de la persona es '{name}', su apellido es '{lastName}', su edad es '{age}', ¿Esta persona sabe programar? '{knowProgramming}'";

        Console.WriteLine(message);

        //Ejercicio 2

        Console.WriteLine("----- Ejercicio 2 ------");
        int doors = 4;
        int wheels = 4;
        string brand = "Ford";
        bool itvValid = true;

        string car = $"EL carro tiene {doors} puertas, también tiene {wheels} ruedas, la marca es {brand}, ¿el itv es valido? {itvValid}";

        Console.WriteLine(car);

        double weight = 22.51;
        double longTable = 15.3;
        string material = "Madera";
        string color = "red";

        string table = $"El peso de la mesa es de {weight}, el largo es {longTable}, el material con es {material} y su color es {color}";
        Console.WriteLine(table);

        //Ejercicio 2

        Console.WriteLine("----- Ejercicio 3 ------");
        int number = 20;
        char letter = 'a';

        bool isGreaterThan = number > 18;
        bool isCharA = letter == 'a';
        bool bothConditions = isGreaterThan && isCharA;
        bool someCondition = isGreaterThan || isCharA;

        string exercise3 = $"¿Es mayor o igual a 18? {isGreaterThan}, ¿El char es a? {isCharA}, ¿Ambas condiciones son verdaderas? {bothConditions}, ¿Alguna condición es verdadera? {someCondition}";
        Console.WriteLine(exercise3);
    }
}