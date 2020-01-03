

using System;
using EjemploDeMediador.Interfaces;
namespace EjemploDeMediador.Interfaces
{
   public abstract class IColleague 
        //Clase abstracta para poder agregar diversas funcionalidades
    {
        private IMediator mediator;
        public IMediator Mediator
        {
            get { return mediator; } /*Se obtiene el mediador*/
        }
        public IColleague(IMediator mediator) {

            this.mediator = mediator;
        }
        public void Communicate(string message) {  
            /*Este metodo no va a comunicar a todos los demas, 
             * sino que por medio del mediador es enviar el mensaje 
             * que se va a recibir*/
            
            this.mediator.Send(message, this);        
        }
        /*Hasta aqui ya se tiene la interfaz de colleague para cmunicarse, 
         *sin embargo el mensaje y la cumicacion se efectuara a traves del mediador*/
        public abstract string Recive(string message); /*Metodo de los colleague para 
                                                      poder recibir los mensajes*/
    }
}
