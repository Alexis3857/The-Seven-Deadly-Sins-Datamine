using Microsoft.Data.Sqlite;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BundleManager
{
    public class StringLocalize
    {
        public StringLocalize()
        {
            string text = "NetmarbleFun&Cherry";
            decryptionKeySize = text.Length;
            decryptionKey = new int[decryptionKeySize];
            for (int i = 0; i < decryptionKeySize; i++)
            {
                decryptionKey[i] = char.ConvertToUtf32(text, i);
            }
        }

        public void Load(string dir, string oldDir)
        {
            string text = "Data Source=";
            _sqliteConnection = new SqliteConnection(text + Path.Combine(dir, "Localization", "LocalizeString_Japanese.bytes"));
            _sqliteConnection.Open();

            _previousSqliteConnection = new SqliteConnection(text + Path.Join(oldDir, "Localization", "LocalizeString_Japanese.bytes"));
            _previousSqliteConnection.Open();

            using (_sqliteCommand = _sqliteConnection.CreateCommand())
            {
                _sqliteCommand.CommandText = "PRAGMA synchronous=OFF";
                _sqliteCommand.ExecuteNonQuery();
                _sqliteCommand.CommandText = "PRAGMA journal_mode=OFF";
                _sqliteCommand.ExecuteNonQuery();
                _sqliteCommand.CommandText = "SELECT translated FROM TRANSLATION WHERE si = @si limit 1";
                _sqliteCommand.Parameters.Add(_paramBySi);
                _sqliteCommand.Prepare();
            }

            using (_previousSqliteCommand = _previousSqliteConnection.CreateCommand())
            {
                _previousSqliteCommand.CommandText = "SELECT COUNT(1) FROM TRANSLATION WHERE id = @id LIMIT 1";
                _previousSqliteCommand.Parameters.Add(_previousParamById);
                _previousSqliteCommand.Prepare();
            }

            using (_previousSqliteCommandGetString = _previousSqliteConnection.CreateCommand())
            {
                _previousSqliteCommandGetString.CommandText = "SELECT translated FROM TRANSLATION WHERE id = @id limit 1";
                _previousSqliteCommandGetString.Parameters.Add(_previousParamById);
                _previousSqliteCommandGetString.Prepare();
            }
        }

        public void WriteNewStringsToFile(string dir, bool isWriteChangedStrings)
        {
            Console.WriteLine("\nGetting the new string from the database...");
            SqliteCommand selectAllCommand = _sqliteConnection.CreateCommand();
            selectAllCommand.CommandText = "SELECT COUNT(*) FROM TRANSLATION";
            var count = selectAllCommand.ExecuteScalar();
            selectAllCommand.CommandText = "SELECT id, translated FROM TRANSLATION";
            SqliteDataReader sqliteDataReader = selectAllCommand.ExecuteReader();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 1; i < Convert.ToInt32(count) + 1; i++)
            {
                Console.Write($"\r{i}/{count}", Console.BufferWidth);
                sqliteDataReader.Read();
                string id = sqliteDataReader.GetString(0);
                _paramById.Value = id;
                string encryptedString = sqliteDataReader.GetString(1);
                if (!IsExistId(id) || (isWriteChangedStrings && IsStringChanged(id, encryptedString)))
                {
                    stringBuilder.AppendLine($"{id} : {StringDecryption(encryptedString)}");
                }
            }
            File.WriteAllText(Path.Join(dir, "Localization", "NewLocalizationString.txt"), stringBuilder.ToString());
            Console.WriteLine("\nDone !");
        }

        private bool IsStringChanged(string key, string newString)
        {
            _previousParamById.Value = key;
            using (SqliteDataReader dataReader = _previousSqliteCommandGetString.ExecuteReader())
            {
                if (dataReader.Read())
                {
                    return dataReader.GetString(0) != newString;
                }
                else
                {
                    return false;
                }
            }
        }

        private bool IsExistId(string key)
        {
            _previousParamById.Value = key;
            using (SqliteDataReader dataReader = _previousSqliteCommand.ExecuteReader())
            {
                if (dataReader.Read())
                {
                    return dataReader.GetInt32(0) > 0;
                }
                else
                {
                    return false;
                }
            }
        }

        public string GetString(string key)
        {
            _paramBySi.Value = key;
            using (SqliteDataReader dataReader = _sqliteCommand.ExecuteReader())
            {
                if (dataReader.Read())
                {
                    return StringDecryption(dataReader.GetString(0));
                }
                else
                {
                    return "NONE DB";
                }
            }
        }

        private string StringDecryption(string str)
        {
            str = ToOriginalString(str);
            int length = str.Length;
            int num = length;
            _sb.Length = 0;
            for (int i = 0; i < length; i++)
            {
                _sb.Append(char.ConvertFromUtf32(char.ConvertToUtf32(str, i) ^ decryptionKey[num % decryptionKeySize]));
                num += length;
                if (num > 1000000)
                {
                    num = length;
                }
            }
            return _sb.ToString();
        }

        private string ToOriginalString(string str)
        {
            _sb.Length = 0;
            int i = 0;
            int length = str.Length;
            while (i < length)
            {
                if (str[i] == '\\' && i + 1 < length)
                {
                    char c = str[i + 1];
                    if (c != '0')
                    {
                        if (c != '\\')
                        {
                            if (c == 'n')
                            {
                                _sb.Append('\n');
                                i += 2;
                            }
                        }
                        else
                        {
                            _sb.Append('\\');
                            i += 2;
                        }
                    }
                    else
                    {
                        _sb.Append('\0');
                        i += 2;
                    }
                }
                else
                {
                    _sb.Append(str[i++]);
                }
            }
            return _sb.ToString();
        }

        private readonly StringBuilder _sb = new StringBuilder();

        private SqliteConnection _sqliteConnection;

        private SqliteConnection _previousSqliteConnection;

        private readonly int[] decryptionKey;

        private readonly int decryptionKeySize;

        private SqliteCommand _sqliteCommand;

        private SqliteCommand _previousSqliteCommand;

        private SqliteCommand _previousSqliteCommandGetString;

        private readonly SqliteParameter _paramById = new("@id", SqliteType.Text);

        private readonly SqliteParameter _previousParamById = new("@id", SqliteType.Text);

        private readonly SqliteParameter _paramBySi = new("@si", SqliteType.Integer);
    }
}