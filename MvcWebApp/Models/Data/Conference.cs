//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcWebApp.Models.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Conference
    {
        public Conference()
        {
            this.Audiences = new HashSet<Audience>();
            this.Levels = new HashSet<Level>();
            this.Locations = new HashSet<Location>();
            this.Resources = new HashSet<Resource>();
            this.Sessions = new HashSet<Session>();
            this.SessionTypes = new HashSet<SessionType>();
            this.Speakers = new HashSet<Speaker>();
            this.Sponsors = new HashSet<Sponsor>();
            this.SponsorshipLevels = new HashSet<SponsorshipLevel>();
            this.Tags = new HashSet<Tag>();
            this.TimeSlots = new HashSet<TimeSlot>();
            this.Tracks = new HashSet<Track>();
            this.Vendors = new HashSet<Vendor>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string Location { get; set; }
        public bool Published { get; set; }
        public string BaseName { get; set; }
        public short TimeOffsetMinutes { get; set; }
        public string Description { get; set; }
        public string ShortName { get; set; }
        public string AccentColor { get; set; }
        public string FacebookURL { get; set; }
        public string WebSiteURL { get; set; }
        public string LinkedInURL { get; set; }
        public string RSSURL { get; set; }
        public string TwitterScreenName { get; set; }
        public string FlickrHandle { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public decimal Altitude { get; set; }
        public string LocationFriendly { get; set; }
        public bool IsWillAttendVisible { get; set; }
        public byte PrivateLabel { get; set; }
        public bool EnableSessionChangeNotifications { get; set; }
        public bool IsFavoritesVisible { get; set; }
        public bool IsRoomVisible { get; set; }
        public bool IsTimeslotVisible { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] Timestamp { get; set; }
    
        public virtual ICollection<Audience> Audiences { get; set; }
        public virtual ICollection<Level> Levels { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
        public virtual ICollection<SessionType> SessionTypes { get; set; }
        public virtual ICollection<Speaker> Speakers { get; set; }
        public virtual ICollection<Sponsor> Sponsors { get; set; }
        public virtual ICollection<SponsorshipLevel> SponsorshipLevels { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<TimeSlot> TimeSlots { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}
