using System.ComponentModel.DataAnnotations;

namespace todoonboard_api.Models
{
    public class Todo
    {
        [Key]
        public int Id {get; set;}
        public string Title {get; set;}
        public bool Done {get; set;}
        public DateTime CeatedAt {get; set;}
        public DateTime UpdatedAt {get; set;}
        public Board BId {get; set;}
    }
}