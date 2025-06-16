using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EventManagement.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
       public string Title { get;set; }

       public string Description {  get;set; }

       public string Category { get; set; }

        [DisplayName("Date & Time")]
        public DateTime Datetime {  get; set; }

       public string Location {  get; set; }

       public string Image {  get; set; }

        [DisplayName("Number of Tickets")]
       public int Numberoftickets {  get; set; }

        [DisplayName("Ticket Price")]
       public double Ticketprice {  get; set; }
    }
}
