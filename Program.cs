using System;
using EjemploDeMediador.Clases;
using EjemploDeMediador.Interfaces;

namespace EjemploDeMediador
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Creamos los objetos respectvos para le mediador y los integrantes del chat*/
            Mediator mediator = new Mediator();
            IColleague Roberth = new User(mediator);
            IColleague Admin = new UserAdmin(mediator);

            /*Hasta ahora tenemos dos objetos que son colegas, ahora se hara que se puedan comunicar
              entre ellos*/


            /*Agregamos a los colegas o participantes de manera que puedan usar el mediador para comunicarse*/
            mediator.Add(Roberth);
            mediator.Add(Admin);

            /*Desarrollo de la conversacion*/
            Roberth.Communicate("Algun admin que me pueda ayudar?");
            Admin.Communicate("Cual es el problema");
            Roberth.Communicate("No me puedo loguear");
            Admin.Communicate("Intenta apagar y encender la pc");
            Roberth.Communicate("Muchas Gracias");


            Console.ReadKey();
        }
    }
}
