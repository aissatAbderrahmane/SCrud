using System.ComponentModel.DataAnnotations;
namespace SCrud.Models
{
    public class Users  
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UserPassword  { get; set; }
        public string UserEmail { get; set; }
        


    }
}
