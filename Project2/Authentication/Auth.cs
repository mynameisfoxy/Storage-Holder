using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
using System.Reactive.Subjects;
using System.IO;
using System.Windows.Forms;

namespace StorageHolder.Authentication
{
    class Auth
    {
        static Auth instance;
        static string RoamingPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Project2";
        static string DataBasePath = RoamingPath + "\\MyData.db";
        Subject<string> UserName = new Subject<string>();

        private Auth()
        {
            CheckBaseExistance();
        }

        public static Auth GetInstance()
        {
            if (instance == null)
            {
                instance = new Auth();
            }

            return instance;
        }

        public void Registration(string Login, string Password)
        {
            SQLiteConnection db = new SQLiteConnection(DataBasePath);

            UserClass RegUserInfo = new UserClass()
            {
                UserName = HashFunc.GetHash(Login),
                PassWord = HashFunc.GetHash(Password)
            };

            db.Insert(RegUserInfo);

            StorageClass RegStorageInfo = new StorageClass()
            {
                DropBox = null,
                Google = null,
                Id = RegUserInfo.Id,
            };

            db.Insert(RegStorageInfo);
        }

        public void LogIn(string Login, string Password)
        {
            SQLiteConnection db = new SQLiteConnection(DataBasePath);
            List<UserClass> DataUserImport = new List<UserClass>();
            List<StorageClass> DataStorageImport = new List<StorageClass>();

            DataUserImport = db.Query<UserClass>("SELECT * FROM UserTable WHERE ColumnUsername='" + HashFunc.GetHash(Login) + "'");
            DataStorageImport = db.Query<StorageClass>("SELECT * FROM StorageKeys WHERE UserId='" + DataUserImport[0].Id + "'");
            
            if (DataUserImport.Count > 0)
            {
                if (DataUserImport[0].PassWord != HashFunc.GetHash(Password))
                {
                    MessageBox.Show("Пароль инкоррект!");
                }
                else
                {
                    AddStorageForm frm = new AddStorageForm(DataStorageImport[0].DropBox, DataStorageImport[0].Google, DataUserImport[0].Id);
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show(Login + " не найден!");
            }
        }

        private void CheckBaseExistance()
        {
            if (!Directory.Exists(RoamingPath))
            {
                Directory.CreateDirectory(RoamingPath);
            }

            SQLiteConnection db = new SQLiteConnection(DataBasePath);

            db.CreateTable<UserClass>();
            db.CreateTable<StorageClass>();
        }

        public IObservable<string> GetUserName()
        {
            return UserName;
        }
    }
}
