using System.Text;
using System.Security.Cryptography;

namespace StorageHolder
{
    class HashFunc
    {
        public static string GetHash(string InputValue)
        {
            MD5 Hasher = MD5.Create();
            // Преобразуем входную строку в массив байт и вычисляем хэш
            byte[] data = Hasher.ComputeHash(Encoding.Default.GetBytes(InputValue));
            // Создаем новый Stringbuilder (Изменяемую строку) для набора байт
            StringBuilder sBuilder = new StringBuilder();
            // Преобразуем каждый байт хэша в шестнадцатеричную строку
            for (int i=0; i<data.Length; i++)
            {
                //указывает, что нужно преобразовать элемент в шестнадцатиричную строку длиной в два символа
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
