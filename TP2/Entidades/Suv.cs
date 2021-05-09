﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }
        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        public override ETamanio Tamanio
        {
            get { return ETamanio.Grande; }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine("---------------------");
            sb.Append(base.Mostrar());
            sb.Append("TAMAÑO : " + this.Tamanio);
            sb.AppendLine("\n\n========================================================================================================");

            return sb.ToString();
        }
    }
}
