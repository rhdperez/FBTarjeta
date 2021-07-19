﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FBTarjeta.Models
{
    public class TarjetaCredito
    {
        public int Id { get; set; } //se considera requerido

        [Required] //dato requerido. Importa System.ComponentModel.DataAnnotations
        public string Titular { get; set; }

        [Required]
        public string NumeroTarjeta { get; set; }

        [Required]
        public string FechaExpiracion { get; set; }

        [Required]
        public string CVV { get; set; }
    }
}
