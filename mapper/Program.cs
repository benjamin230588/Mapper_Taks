using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapper
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
           
            departamento depa = new departamento();
            depa.correo = "benja";
            depa.nombre = "pepe";

            distrito dis = new distrito();

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<departamento, distrito>();
            });

            IMapper iMapper = config.CreateMapper();
            dis = iMapper.Map<departamento, distrito>(depa);

            Console.Read();
            //Mapper.CreateMap<departamento, distrito>();
            //primer cambio 
        }

    }

    class departamento
    {

        public string correo { get; set; }
        public string nombre { get; set; }


    }

    class distrito
    {
        public string correo { get; set; }
        public string nombre { get; set; }

        public string habitantes { get; set; }
        public string cantidad { get; set; }

    }
}
