using SQLite;

namespace StorageHolder
{
    [Table("StorageKeys")]
    public class StorageClass
    {
        [PrimaryKey, Column("UserId"), NotNull]
        public int Id { get; set; }
        [Column("DropboxKey")]
        public string DropBox { get; set; }
        [Column("GoogleKey")]
        public string Google { get; set; }
    }
}