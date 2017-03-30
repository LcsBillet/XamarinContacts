using SQLite;

namespace People.Models
{
    [Table("people")]
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(250), Unique]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Firstname { get; set; }

        [MaxLength(15), Unique]
        public string Numero { get; set; }
    }
}