using System;
using Principios_solid.SOLID.ISP.Violacao.Interfaces;


namespace Principios_solid.SOLID.ISP.Violacao.Models
{
    public class Geladeira : IEletrodomestico
    {
        public void Esfriar()
        {
            //a geladeira só precisa disso aqui
        }
    }
}