using SQLite;

namespace StorageHolder
{
    [Table("UserTable")]
    public class UserClass
    {
        [PrimaryKey, AutoIncrement, Column("UserId"), NotNull]
        public int Id { get; set; }
        [Column("ColumnUsername"), NotNull]
        public string UserName { get; set; }
        [Column("ColumnPasword"), NotNull]
        public string PassWord { get; set; }
    }
}
