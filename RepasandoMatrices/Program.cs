using System;

namespace RepasandoMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            ////tipo[,] nombre = new tipo[fila,columna];
            //int a = 4;
            //int b = 3;
            //double[,] calificaciones = new double[a, b];

            //calificaciones[2, 1] = 9.0;

            //Console.WriteLine(calificaciones[2, 1]);

            //calificaciones[0, 2] = 7.0;

            //Console.WriteLine(calificaciones[0, 2]);

            //calificaciones[3, 0] = calificaciones[2, 1] * calificaciones[0, 2];

            //Console.WriteLine(calificaciones[3, 0]);

            //int i; //Ciclo exterior
            //int j // Ciclo interior

            //for (i = 0; i < 3; i++)  // 3 Salones
            //{
            //    for (j = 0; i < 4; j++) // 4 Alumnos por salon
            //    {

            //        Console.WriteLine("Salon{0} , Alumno{1}", i + 1, j + 1);
            //    }
            //    Console.WriteLine();
            //}

            int salones = 0;
            int alumnos = 0;

            int i; // Ciclo exterior (Salones)
            int j; // Ciclo interior (Alumnos)

            double suma = 0.0;
            double promedio = 0.0;

            double calMinima = 10.0;
            double calMaxima = 0.0;

            // Pedir la cantidad de salones

            Console.Write("Dame la cantidad de salones : ");
            salones = Convert.ToInt32(Console.ReadLine());

            // Pedir la cantidad de alumnos

            Console.Write("Dame la cantidad de alumnos por salon : ");
            alumnos = Convert.ToInt32(Console.ReadLine());

            // Creamos el arreglo

            double[,] calificaciones = new double[salones, alumnos];

            for (i = 0; i < salones; i++)  //  Salones
            {
                Console.WriteLine("Salon {0}", i + 1);
                for (j = 0; i < alumnos; j++) // Alumnos por salon
                {

                    Console.Write("Dame la calificacion del alumno{0}", j + 1);
                    calificaciones[i, j] = Convert.ToDouble(Console.ReadLine());
                }

            }

            // Calcular el promedio

            for (i = 0; i < salones; i++)  //  Salones
            {
                for (j = 0; i < alumnos; j++) // Alumnos por salon
                {

                    suma = suma + calificaciones[i, j];
                }

            }
            promedio = suma / (salones * alumnos);

            // Calificacion Minima

            for (i = 0; i < salones; i++)  //  Salones
            {
                for (j = 0; i < alumnos; j++) // Alumnos por salon
                {

                    if (calificaciones[i, j] < calMinima) 
                    {
                        calMinima = calificaciones[i, j];
                    }
                }

            }

            // Calificacion Maxima

            for (i = 0; i < salones; i++)  //  Salones
            {
                for (j = 0; i < alumnos; j++) // Alumnos por salon
                {

                    if (calificaciones[i, j] > calMaxima)
                    {
                        calMaxima = calificaciones[i, j];
                    }
                }

            }

            //Mostrar los resultados

            Console.WriteLine("El promedio es {0} : ", promedio);
            Console.WriteLine("La calificacion maxima es {0} : ", calMaxima);
            Console.WriteLine("La calificacion minima es {0} : ", calMinima);

        }


    }
}
