﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdEmpresa { get; set; }
        public int IdCargo { get; set; }

        public virtual Cargo IdCargoNavigation { get; set; }
        public virtual Empresa IdEmpresaNavigation { get; set; }
    }
}