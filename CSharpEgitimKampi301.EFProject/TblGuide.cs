//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSharpEgitimKampi301.EFProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblGuide
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblGuide()
        {
            this.TblLocation = new HashSet<TblLocation>();
        }
    
        public int GuideId { get; set; }
        public string GuideName { get; set; }
        public string GuideSurname { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblLocation> TblLocation { get; set; }
    }
}
