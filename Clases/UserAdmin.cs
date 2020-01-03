using System;
using EjemploDeMediador.Interfaces;
using EjemploDeMediador.Clases;

namespace EjemploDeMediador.Clases
{
    public class UserAdmin : IColleague
    {
        public UserAdmin(IMediator mediator) : base(mediator) /*Recibe el mediador*/
        {
        }
        public override string Recive(string message)
        {
            return "Un administrador recibe: "+message;
            
        }
    }
}
/*Profesor Buenas
 Aqui le dejare un link a GitHub con el mismo codigo pero sin los Console.WriteLine(); dentro de las clases 
 User y UserAdmin ,esto para hacer ver al codigo mejor, sin embargo no mostraba nada a pesar de que ya no 
 me daba ningun error en el Visual
 Disculpe las molestias.*/
