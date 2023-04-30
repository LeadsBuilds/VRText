using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace VRText.Handlers
{
   public class SQLiteHandler
   {
      static ErrorHandler errorHandlerSQLite;
      
      public static void init()
      {
         var conn = CreateConnection();
         CreateMessageTable(conn);
         CreateSettingsTable(conn);
      }

      static SQLiteConnection CreateConnection()
      {
         SQLiteConnection conn;
         // Create a new database connection:
         conn = new SQLiteConnection("Data Source=|DataDirectory|vrtext.db;Version = 3;New = True;Compress = True;");
         // Open the connection:
         try
         {
            conn.Open();
         }
         catch (Exception e)
         {
            throw new Exception("Error: " + e.Message);
         }
         
         return conn;
      }

      public static void InsertNewMessage(List<string> message)
      {
         SQLiteConnection conn = CreateConnection();
         var messageText = message[0];
         var createdAt = message[1];

         var command = conn.CreateCommand();
         command.CommandText = "INSERT INTO messages (Message, created_at) VALUES(@message, @createdAt);";
         command.Parameters.AddWithValue("@message", messageText);
         command.Parameters.AddWithValue("@createdAt", createdAt);
         command.Prepare();
         
         ExecSql(command.CommandText, conn, command);
      }

      public static List<string[]> GetAllMessages()
      {
         SQLiteConnection conn = CreateConnection();
         var sql = "SELECT * FROM messages;";

         var command = new SQLiteCommand(sql, conn); 
         var reader = command.ExecuteReader();
         var messages = new List<string[]>();
         while (reader.Read())
         {
            string[] row = { reader.GetString(0), reader.GetString(1) };
            messages.Add(row);
         }

         return messages;
      }
      
      public static void DeleteSingleMessage(List<string> message)
      {
         SQLiteConnection conn = CreateConnection();
         var messageText = message[0];
         var createdAt = message[1];

         var command = conn.CreateCommand();
         command.CommandText = "DELETE FROM messages WHERE Message = @message AND created_at = @createdAt";
         command.Parameters.AddWithValue("@message", messageText);
         command.Parameters.AddWithValue("@createdAt", createdAt);
         command.Prepare();
         
         ExecSql(command.CommandText, conn, command);
      }
      
      public static void DeleteAllMessages()
      {
         SQLiteConnection conn = CreateConnection();
         
         var sql = "DELETE FROM messages;";
         
         ExecSql(sql, conn);
      }

      public static List<string[]> LoadSettings()
      {
         SQLiteConnection conn = CreateConnection();
         var sql = "SELECT * FROM settings LIMIT 1;";

         var command = new SQLiteCommand(sql, conn); 
         var reader = command.ExecuteReader();
         var rows = new List<string[]>();
         while (reader.Read())
         {
            string[] row = { reader.GetString(0), reader.GetInt16(1).ToString(), reader.GetString(2), reader.GetString(3) };
            rows.Add(row);
         }

         return rows;
      }
      
      public static void UpdateOSCSettings(string ip, string port)
      {
         SQLiteConnection conn = CreateConnection();
         var sql = "UPDATE settings SET ServerAddress=:ip, ServerPort=:port;";

         var command = new SQLiteCommand(conn);
         command.CommandText = sql;
         command.Parameters.Add("ip", DbType.String).Value = ip;
         command.Parameters.Add("port", DbType.String).Value = port;
         command.Prepare();
         
         ExecSql(command.CommandText, conn, command);
      }
      
      public static void UpdateLanguageSettings(string lang)
      {
         SQLiteConnection conn = CreateConnection();
         var sql = "UPDATE settings SET Lang=:lang;";

         var command = new SQLiteCommand(conn);
         command.CommandText = sql;
         command.Parameters.Add("lang", DbType.String).Value = lang;
         command.Prepare();
         
         ExecSql(command.CommandText, conn, command);
      }
      
      public static void UpdateSpotifyPrefix(string prefix)
      {
         SQLiteConnection conn = CreateConnection();
         var sql = "UPDATE settings SET SpotifyPREFIX=:prefix;";

         var command = new SQLiteCommand(conn);
         command.CommandText = sql;
         command.Parameters.Add("prefix", DbType.String).Value = prefix;
         command.Prepare();
         
         ExecSql(command.CommandText, conn, command);
      }
      public static void InitSettings(string[] data)
      {
         SQLiteConnection conn = CreateConnection();
         var serverAddress = data[0];
         var serverPort = data[1];
         var spotifyPrefix = data[2];
         var lang = data[3];

         var command = conn.CreateCommand();
         command.CommandText = "INSERT INTO settings (ServerAddress, ServerPort, SpotifyPREFIX, Lang) VALUES(@serverAddress, @serverPort, @spotifyPrefix, @lang);";
         command.Parameters.AddWithValue("@serverAddress", serverAddress);
         command.Parameters.AddWithValue("@serverPort", serverPort);
         command.Parameters.AddWithValue("@spotifyPrefix", spotifyPrefix);
         command.Parameters.AddWithValue("@lang", lang);
         command.Prepare();
         
         ExecSql(command.CommandText, conn, command);
      }

      public static string GetLanguage()
      {
         var loadSettings = LoadSettings();

         if (loadSettings.Any())
         {
            var settingsValues = loadSettings[0];
            return settingsValues[3];
         }

         return "";
      }
      
      static void CreateMessageTable(SQLiteConnection conn)
      {
         string sql = "CREATE TABLE IF NOT EXISTS messages (Message VARCHAR(144), created_at VARCHAR(100));";

         ExecSql(sql, conn);
      }
      
      static void CreateSettingsTable(SQLiteConnection conn)
      {
         string sql = "CREATE TABLE IF NOT EXISTS settings (ServerAddress VARCHAR(144), ServerPort INT(5), SpotifyPREFIX VARCHAR(100), Lang VARCHAR(10));";

         ExecSql(sql, conn);
      }

      static void ExecSql(string sql, SQLiteConnection conn, SQLiteCommand command = null)
      {
         if (command == null)
         {
            command = conn.CreateCommand();
            command.CommandText = sql;
         }

         command.ExecuteNonQuery();
      }
   }
}

