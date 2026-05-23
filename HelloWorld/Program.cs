namespace HelloWorld
{

    class Program
    {
        static void Main()
        {
            DateOnly dateConverted = new DateOnly();
            String nameInput;
            String birthdayInput;
            Console.WriteLine("Hola, Bienvenido a el calculador de años");
            Console.WriteLine("Esribe tu nombre:  ");
            nameInput = Console.ReadLine();
            Console.WriteLine($"Un gusto conocerte {nameInput} ");
            Console.WriteLine("Escribe tu fecha de nacimiento (dd/mm/yyyy):  ");
            birthdayInput = Console.ReadLine();
            bool isDateValid = DateOnly.TryParse(birthdayInput, out dateConverted);
            if (isDateValid == false) Console.WriteLine("La fecha no es valida, por favor intentalo de nuevo");
            var persone = new Person()
            {
                Name = nameInput,
                Bithday = dateConverted,
                Age = DateTime.Now.Year - dateConverted.Year
            };
            Console.WriteLine($"Tu nombre es {persone.Name} y tu fecha de nacimiento es {persone.Bithday}");
            Console.WriteLine($"Tu edad es: {persone.Age}  años");

            Console.WriteLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly Bithday { get; set; }
    }
}