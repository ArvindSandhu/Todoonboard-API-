using System.ComponentModel.DataAnnotations;


namespace todoonboard_api.Models{
    public class Board{
        [Key]
        public int id {get; set;}
        public string? BoardName {get; set;}
    }
}