using System.ComponentModel.DataAnnotations;

namespace Ticket_System_3_Organic_Tree.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description {  get; set; }
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }
    }
}
