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
    
    public partial class praticien
    {
        public praticien()
        {
            this.rapport_visite = new HashSet<rapport_visite>();
        }
    
        public int id_praticien { get; set; }
        public Nullable<int> id_type_praticien { get; set; }
        public string nom_praticien { get; set; }
        public string prenom_praticien { get; set; }
        public string adresse_praticien { get; set; }
        public string cp_praticien { get; set; }
        public string ville_praticien { get; set; }
        public Nullable<decimal> coef_notoriete { get; set; }
    
        public virtual type_praticien type_praticien { get; set; }
        public virtual ICollection<rapport_visite> rapport_visite { get; set; }
    }
}
