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
    
    public partial class voiture
    {
        public int idVoiture { get; set; }
        public int idGarage { get; set; }
        public int idTypeV { get; set; }
        public int idModele { get; set; }
        public Nullable<long> numSerieV { get; set; }
        public Nullable<int> nbPassagerV { get; set; }
        public Nullable<int> nbKmV { get; set; }
        public Nullable<int> puissanceV { get; set; }
        public string couleurV { get; set; }
        public string energieV { get; set; }
        public Nullable<long> prixVenteV { get; set; }
        public string boiteDeVitesseV { get; set; }
    
        public virtual garage garage { get; set; }
        public virtual modele modele { get; set; }
        public virtual type_de_voiture type_de_voiture { get; set; }
    }
}
