using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Party.Models
{
    public class Party
    {
<<<<<<< HEAD
        public string Id { get; set; }
=======
        public int PartyId { get; set; }
>>>>>>> 11120ee0546093d4fb989a8269084f406b55c6be
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureName { get; set; }
        public DateTime Time { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public string LocationName { get; set; }

<<<<<<< HEAD
        {
=======
        public Party(int partyId,string name, string pictureName, string description, DateTime time, string locationName, string city, string adress)
        {
            PartyId = partyId;
>>>>>>> 11120ee0546093d4fb989a8269084f406b55c6be
            Name = name;
            Description = description;
            PictureName = pictureName;
            Time = time;
            LocationName = locationName;
            City = city;
            Adress = adress;
        }
<<<<<<< HEAD
       */
=======
>>>>>>> 11120ee0546093d4fb989a8269084f406b55c6be
    }
}
