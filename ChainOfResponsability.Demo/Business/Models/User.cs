using System;
using System.Globalization;

namespace ChainOfResponsability.Demo.Business.Models
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string SocialSecurityNumber { get; set; }
        public RegionInfo RegionInfo { get; set; }
        public CitizenshipRegion CitizenshipRegion { get; set; }
        public DateTimeOffset DateTimeOffset { get; set; }

        public User(
            string name,
            string socialSecurityNumber,
            RegionInfo regionInfo,
            DateTimeOffset dateTimeOffset)
        {
            Name = name;
            SocialSecurityNumber = socialSecurityNumber;
            RegionInfo = regionInfo;
            DateTimeOffset = dateTimeOffset;
        }
    }
}
