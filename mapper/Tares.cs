using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mapper
{
    class Tares
    {
        static async Task Main(string[] args)
        {
            // task independiente para ejecutar tareas asincronas
            // task 
            // async y await para metodos asincronos
            // await valida si la tarea se a terminado
            var tarea = new Task(() =>
            {
                Thread.Sleep(4000);
                Console.WriteLine("asincrona tarea 1");
            }
            );
            tarea.Start();

            var tarea2 = new Task(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("asincrona tarea 2");
            }
            );
            tarea2.Start();
            await tarea;
            await tarea2;
            int res = await prueba();
            Console.WriteLine(res);

            //await tarea;
            Console.WriteLine("Primera tarea");
            Console.ReadLine();
        }

        static async Task<int> prueba ()
        {
            var tarea = new Task<int>(() => new Random().Next(1000));
            tarea.Start();
            int resul =await tarea;
            return resul;

        }
    }
}
