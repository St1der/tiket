
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
    
public partial class Ticket
{

    public int Id { get; set; }

    public int CityId { get; set; }

    public int ScheduleId { get; set; }

    public int FlightTypeId { get; set; }



    public virtual City City { get; set; }

    public virtual FlightType FlightType { get; set; }

    public virtual Schedule Schedule { get; set; }

}

}
