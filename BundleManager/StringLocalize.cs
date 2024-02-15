using Microsoft.Data.Sqlite;
using System.Text;

namespace _7dsgcDatamine
{
    public class StringLocalize
    {
        public StringLocalize()
        {
            string key = "NetmarbleFun&Cherry";
            decryptionKeySize = key.Length;
            decryptionKey = new int[decryptionKeySize];
            for (int i = 0; i < decryptionKeySize; i++)
            {
                decryptionKey[i] = char.ConvertToUtf32(key, i);
            }
        }

        public bool Load(string newLocalizationPath, string previousLocalizationPath)
        {
            if (!File.Exists(newLocalizationPath) || !File.Exists(previousLocalizationPath))
            {
                Console.WriteLine("Impossible to compare the localization database because the required file does not exist");
                return false;
            }
            string text = "Data Source=";
            _sqliteConnection = new SqliteConnection(text + newLocalizationPath);
            _sqliteConnection.Open();

            _prevSqliteConnection = new SqliteConnection(text + previousLocalizationPath);
            _prevSqliteConnection.Open();

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

            using (_prevSqliteCommand = _prevSqliteConnection.CreateCommand())
            {
                _prevSqliteCommand.CommandText = "SELECT COUNT(1) FROM TRANSLATION WHERE id = @id LIMIT 1";
                _prevSqliteCommand.Parameters.Add(_previousParamById);
                _prevSqliteCommand.Prepare();
            }

            using (_prevSqliteCommandGetString = _prevSqliteConnection.CreateCommand())
            {
                _prevSqliteCommandGetString.CommandText = "SELECT translated FROM TRANSLATION WHERE id = @id limit 1";
                _prevSqliteCommandGetString.Parameters.Add(_previousParamById);
                _prevSqliteCommandGetString.Prepare();
            }

            return true;
        }

        public void WriteNewStringsToFile(string outputDirectory)
        {
            Console.WriteLine("\nGetting the new string from the database...");
            SqliteCommand selectAllCommand = _sqliteConnection.CreateCommand();
            selectAllCommand.CommandText = "SELECT COUNT(*) FROM TRANSLATION";
            var count = selectAllCommand.ExecuteScalar();
            selectAllCommand.CommandText = "SELECT id, translated FROM TRANSLATION";
            SqliteDataReader sqliteDataReader = selectAllCommand.ExecuteReader();
            StringBuilder newStrSB = new StringBuilder();
            StringBuilder changedStrSB = new StringBuilder();
            for (int i = 1; i < Convert.ToInt32(count) + 1; i++)
            {
                Console.Write($"\r{i}/{count}", Console.BufferWidth);
                sqliteDataReader.Read();
                string id = sqliteDataReader.GetString(0);
                _paramById.Value = id;
                string encryptedString = sqliteDataReader.GetString(1);
                if (!IsExistId(id))
                {
                    newStrSB.AppendLine($"{id} : {StringDecryption(encryptedString)}");
                }
                else if (IsStringChanged(id, encryptedString))
                {
                    changedStrSB.AppendLine($"{id} : {StringDecryption(encryptedString)}");
                }
            }
            File.WriteAllText(Path.Combine(outputDirectory, "NewLocalizationString.txt"), newStrSB.ToString());
            File.WriteAllText(Path.Combine(outputDirectory, "ChangedLocalizationString.txt"), changedStrSB.ToString());
            Console.WriteLine("\nDone !");
        }

        private bool IsStringChanged(string key, string newString)
        {
            _previousParamById.Value = key;
            using (SqliteDataReader dataReader = _prevSqliteCommandGetString.ExecuteReader())
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
            using (SqliteDataReader dataReader = _prevSqliteCommand.ExecuteReader())
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
            if (_sqliteCommand != null)
            {
                using (SqliteDataReader dataReader = _sqliteCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        return StringDecryption(dataReader.GetString(0));
                    }
                }
            }
            return "NONE DB";
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

        private SqliteConnection _prevSqliteConnection;

        private readonly int[] decryptionKey;

        private readonly int decryptionKeySize;

        private SqliteCommand _sqliteCommand;

        private SqliteCommand _prevSqliteCommand;

        private SqliteCommand _prevSqliteCommandGetString;

        private readonly SqliteParameter _paramById = new("@id", SqliteType.Text);

        private readonly SqliteParameter _previousParamById = new("@id", SqliteType.Text);

        private readonly SqliteParameter _paramBySi = new("@si", SqliteType.Integer);
    }
}
