//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_event()
        {
            this.Tbl_guests = new HashSet<Tbl_guests>();
            this.Tbl_table = new HashSet<Tbl_table>();
        }
    
        public int id { get; set; }
        public int id_event_owner { get; set; }
        public byte event_type_code { get; set; }
        public System.DateTime date { get; set; }
        public string picture { get; set; }
        public string free_text { get; set; }
        public string name { get; set; }
    
        public virtual Tbl_event_owner_ Tbl_event_owner_ { get; set; }
        public virtual Tbl_event_type Tbl_event_type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_guests> Tbl_guests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_table> Tbl_table { get; set; }
    }
}
