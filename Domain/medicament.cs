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
    
    public partial class medicament
    {
        public medicament()
        {
            this.constituer = new HashSet<constituer>();
            this.offrir = new HashSet<offrir>();
        }
    
        public int id_medicament { get; set; }
        public Nullable<int> id_famille { get; set; }
        public string depot_legal { get; set; }
        public string nom_commercial { get; set; }
        public string effets { get; set; }
        public string contre_indication { get; set; }
        public Nullable<decimal> prix_echantillon { get; set; }
    
        public virtual ICollection<constituer> constituer { get; set; }
        public virtual famille famille { get; set; }
        public virtual ICollection<offrir> offrir { get; set; }
    }
}