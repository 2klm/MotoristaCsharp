//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesignModern
{
    using System;
    using System.Collections.Generic;
    
    public partial class garage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public garage()
        {
            this.commande = new HashSet<commande>();
            this.voiture = new HashSet<voiture>();
        }
    
        public int idGarage { get; set; }
        public int idType { get; set; }
        public string nomG { get; set; }
        public string adresseG { get; set; }
        public string cpG { get; set; }
        public string telG { get; set; }
        public string emailG { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<commande> commande { get; set; }
        public virtual type_de_garage type_de_garage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<voiture> voiture { get; set; }
    }
}
