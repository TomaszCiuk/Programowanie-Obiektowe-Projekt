//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Programowanie_Obiektowe___Projekt
{
    using System;
    using System.Collections.Generic;
    
    public partial class Itemy
    {
        public int ID { get; set; }
        public string Nazwa { get; set; }
        public Nullable<int> KategoriaID { get; set; }
    
        public virtual Kategoria Kategoria { get; set; }
    }
}
