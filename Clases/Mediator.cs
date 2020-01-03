using System;
using System.Collections.Generic;
using EjemploDeMediador.Interfaces;

namespace EjemploDeMediador.Clases
{
    public class Mediator : IMediator /*Esta clase sera la encargada de enviador de mensajes
                                        como tal*/
    {
        private List<IColleague> colleague;//Esta lista de los de los colleagues o integrantes del chat

        public Mediator() {

            colleague = new List<IColleague>();/*Se crea la lista de Colleagues involucrados*/
        }
        public void Add(IColleague colleague) { /*Metodo encargado de agregar los
                                                  colegas*/

            this.colleague.Add(colleague);//se agrega colega convirtiendose en un receptor
        }

        public void Send(string message, IColleague colleague)
        {
            foreach (var c in this.colleague)/*Revisa la lista para saber que integrante recibira el mensaje*/
            {
                if(colleague!=c)
                {/*Con la instruccion colleague!=c se asegura que el mensaje no lo reciba la misma persona 
                    que envia el mensaje*/
                    c.Recive(message);
                }
            } 
        }
    }
}
