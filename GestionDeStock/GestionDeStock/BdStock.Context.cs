﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DbStockContext : DbContext
    {
        public DbStockContext()
            : base("name=DbStockContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<achat> achats { get; set; }
        public virtual DbSet<categorie> categories { get; set; }
        public virtual DbSet<client> clients { get; set; }
        public virtual DbSet<detail_achat> detail_achat { get; set; }
        public virtual DbSet<fournisseur> fournisseurs { get; set; }
        public virtual DbSet<produit> produits { get; set; }
        public virtual DbSet<utilisateur> utilisateurs { get; set; }
        public virtual DbSet<vente> ventes { get; set; }
        public virtual DbSet<vente_detail> vente_detail { get; set; }
    
        public virtual ObjectResult<sp_all_fourniss_Result> sp_all_fourniss()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_all_fourniss_Result>("sp_all_fourniss");
        }
    
        public virtual int sp_delete_fourniss(Nullable<int> idfour)
        {
            var idfourParameter = idfour.HasValue ?
                new ObjectParameter("idfour", idfour) :
                new ObjectParameter("idfour", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_delete_fourniss", idfourParameter);
        }
    
        public virtual ObjectResult<fournisseur> sp_insert_fourniss(string nom_fourn, string tel)
        {
            var nom_fournParameter = nom_fourn != null ?
                new ObjectParameter("nom_fourn", nom_fourn) :
                new ObjectParameter("nom_fourn", typeof(string));
    
            var telParameter = tel != null ?
                new ObjectParameter("tel", tel) :
                new ObjectParameter("tel", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<fournisseur>("sp_insert_fourniss", nom_fournParameter, telParameter);
        }
    
        public virtual ObjectResult<fournisseur> sp_insert_fourniss(string nom_fourn, string tel, MergeOption mergeOption)
        {
            var nom_fournParameter = nom_fourn != null ?
                new ObjectParameter("nom_fourn", nom_fourn) :
                new ObjectParameter("nom_fourn", typeof(string));
    
            var telParameter = tel != null ?
                new ObjectParameter("tel", tel) :
                new ObjectParameter("tel", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<fournisseur>("sp_insert_fourniss", mergeOption, nom_fournParameter, telParameter);
        }
    
        public virtual ObjectResult<sp_serch_fourn_Result> sp_serch_fourn(string txtserch)
        {
            var txtserchParameter = txtserch != null ?
                new ObjectParameter("txtserch", txtserch) :
                new ObjectParameter("txtserch", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_serch_fourn_Result>("sp_serch_fourn", txtserchParameter);
        }
    
        public virtual int sp_update_fourn(Nullable<int> idfour, string nom_foun, string tel)
        {
            var idfourParameter = idfour.HasValue ?
                new ObjectParameter("idfour", idfour) :
                new ObjectParameter("idfour", typeof(int));
    
            var nom_founParameter = nom_foun != null ?
                new ObjectParameter("nom_foun", nom_foun) :
                new ObjectParameter("nom_foun", typeof(string));
    
            var telParameter = tel != null ?
                new ObjectParameter("tel", tel) :
                new ObjectParameter("tel", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_update_fourn", idfourParameter, nom_founParameter, telParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}