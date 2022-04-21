using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression();
            arithProgression.setStart(12);
            arithProgression.setStep(3);
            Console.WriteLine("Арифметическая прогрессия:");
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());

            arithProgression.reset();
            Console.WriteLine("Сброс и изменение шага:");
            arithProgression.setStep(4);
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());

            GeomProgression geomProgression = new GeomProgression();
            geomProgression.setStart(10);
            geomProgression.setStep(2);

            Console.WriteLine("\nГеометрическая прогрессия:");
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());

            geomProgression.reset();
            Console.WriteLine("Сброс и изменение шага:");
            geomProgression.setStep(4);
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            Console.ReadKey();
        }
    }
}
