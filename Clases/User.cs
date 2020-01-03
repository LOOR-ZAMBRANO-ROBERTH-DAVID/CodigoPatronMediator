using System;
using EjemploDeMediador.Interfaces;

namespace EjemploDeMediador.Clases
{
    public class User : IColleague
    {
        public User(IMediator mediator) : base(mediator) /*Recibe el mediador*/
        {
        }
        public override string  Recive(string message)
        {
            return "Un usuario recibe: " + message;
        }
    }
}
