//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class constituer
    {
        public int id_composant { get; set; }
        public int id_medicament { get; set; }
        public Nullable<decimal> qte_composant { get; set; }
    
        public virtual composant composant { get; set; }
        public virtual medicament medicament { get; set; }
    }
}
