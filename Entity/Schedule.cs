
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Entity
{

using System;
    using System.Collections.Generic;
    
public partial class Schedule
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Schedule()
    {

        this.Airplanes = new HashSet<Airplane>();

        this.Tickets = new HashSet<Ticket>();

    }


    public int Id { get; set; }

    public System.DateTime StartDateTime { get; set; }

    public int CityId { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Airplane> Airplanes { get; set; }

    public virtual City City { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Ticket> Tickets { get; set; }

}

}
