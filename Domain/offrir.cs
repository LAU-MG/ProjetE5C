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
    
    public partial class offrir
    {
        public int id_medicament { get; set; }
        public int id_rapport { get; set; }
        public int id_visiteur { get; set; }
        public Nullable<int> qte_offerte { get; set; }
    
        public virtual medicament medicament { get; set; }
        public virtual rapport_visite rapport_visite { get; set; }
    }
}
