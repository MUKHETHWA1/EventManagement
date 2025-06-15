using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.ComponentModel.DataAnnotations;

namespace EventManagement.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
       public string Title { get;set; }

       public string Description {  get;set; }

       public string Category { get; set; }

        public DateTime Datetime {  get; set; }

       public string Location {  get; set; }

       public IFormFile Image {  get; set; }

       public int Numberoftickets {  get; set; }

       public double Ticketprice {  get; set; }
    }
}
