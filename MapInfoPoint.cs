//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Updater
{
    using System;
    using System.Collections.Generic;
    
    public partial class MapInfoPoint
    {
        public int MapInfoPointID { get; set; }
        public int MapInfoID { get; set; }
        public int Ordinal { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public System.DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }
    
        public virtual MapInfo MapInfo { get; set; }
    }
}
