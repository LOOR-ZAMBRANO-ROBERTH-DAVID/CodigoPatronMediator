using System;

namespace EjemploDeMediador.Interfaces
{
    public interface IMediator
    {
       void Send(String message, IColleague colleague); /*declaracion del mensaje y el 
                                                          destinatario, es decir un colleague*/
    }
}
