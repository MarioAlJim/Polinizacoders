//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OcaDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Report
    {
        public int IdReport { get; set; }
        public string typeReport { get; set; }
        public Nullable<int> IdUser { get; set; }
    
        public virtual User User { get; set; }
    }
}
