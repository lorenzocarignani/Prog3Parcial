﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class Empresa
    {
        public Empresa()
        {
            Empleado = new HashSet<Empleado>();
        }

        public int Id { get; set; }
        public string RazonSocial { get; set; }

        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}