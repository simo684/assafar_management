//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionDeStock
{
    using System;
    using System.Collections.Generic;
    
    public partial class produit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public produit()
        {
            this.detail_achat = new HashSet<detail_achat>();
            this.vente_detail = new HashSet<vente_detail>();
        }
    
        public int id_produit { get; set; }
        public string nom_produit { get; set; }
        public int quantite { get; set; }
        public string prix_vente { get; set; }
        public int id_categorie { get; set; }
    
        public virtual categorie categorie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detail_achat> detail_achat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vente_detail> vente_detail { get; set; }
    }
}
