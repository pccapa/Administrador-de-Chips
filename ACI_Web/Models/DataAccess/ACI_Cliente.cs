//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ACI_Web.Models.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class ACI_Cliente
    {
        public ACI_Cliente()
        {
            this.ACI_Paciente = new HashSet<ACI_Paciente>();
        }
    
        public int idCliente { get; set; }
        public string nombreCliente { get; set; }
        public string apellidoPaternoCliente { get; set; }
        public string apellidoMaternoCliente { get; set; }
        public string dniCliente { get; set; }
    
        public virtual ICollection<ACI_Paciente> ACI_Paciente { get; set; }
    }
}
