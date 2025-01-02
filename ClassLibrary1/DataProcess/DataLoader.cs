
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace UtilityLib.DataProcess
{
    //데이터 로드: DataLoader에서 데이터를 읽어옴
    
    public class DataLoader
    {
        public static string _dbPath = AppDomain.CurrentDomain.BaseDirectory + "SJ_FNC.db";
        public static string connectionString = $"Data Source={_dbPath};Version=3;";
        public static SQLiteConnection connection;
        public static SQLiteCommand command;
        public StreamReader rdr;
        public enum  FileType
        {
            TXT,
            PDF,
            CSV,
            XML,
            xlsx
        }

        public void ReadFromFile(string FilePath, FileType FileType)
        {
            switch (FileType)
            {
                case FileType.CSV:
                    CSV_Parser(FilePath);
                    BulkInsert(FilePath);
                    break;
                case FileType.TXT:
                    break;
                case FileType.PDF:
                    break;
                case FileType.XML:
                    break;
                case FileType.xlsx:
                    break;
            }
        }


        public void CSV_Parser(string FilePath)
        {
            //CSV 파일이 들어오면 일단 Parsing
           rdr = new StreamReader(FilePath);
            var csvrdr = new CsvReader(rdr,CultureInfo.InvariantCulture);
        }


        public void CreateDB()
        {
            // 애플리케이션 실행 경로에 DB 파일 생성

            // SQLite 연결
            connection = new SQLiteConnection(connectionString);
                connection.Open();

            // 테이블 생성 SQL
            string createTableQuery = @"
               CREATE TABLE IF NOT EXISTS tb_data (
                Date VARCHAR(50),
                Model VARCHAR(50),
                SerialNo VARCHAR(50),
                Spec1  VARCHAR(50),
                Spec1Jug VARCHAR(50),
                Spec2  VARCHAR(50),
                Spec2Jug VARCHAR(50),
                Spec3 VARCHAR(50),
                Spec3Jug VARCHAR(50),
                PrimaryKey(Date)
            )";

            command = new SQLiteCommand(createTableQuery, connection);
                
                    command.ExecuteNonQuery();
                    Console.WriteLine("Database and table created successfully.");
                
            }
        

        public void BulkInsert(string csvPath)
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                var transaction = connection.BeginTransaction();
                string insertQuery = @"
                        INSERT INTO tb_data (Date, Model, SerialNo, Spec, Limit, Tilt, Height, HValue, VValue)
                        VALUES (@Date, @Model, @SerialNo, @Spec, @Limit, @Tilt, @Height, @HValue, @VValue);";

                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection, transaction))
                {
                    foreach (var line in File.ReadAllLines(csvPath))
                    {
                        if (line.StartsWith("Date")) // Skip header
                            continue;
                        var values = line.Split(',');
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@Date", values[0]);
                        command.Parameters.AddWithValue("@Model", values[1]);
                        command.Parameters.AddWithValue("@SerialNo", values[2]);
                        command.Parameters.AddWithValue("@Spec", values[3]);
                        command.Parameters.AddWithValue("@Limit", values[4]);
                        command.Parameters.AddWithValue("@Tilt", values[5]);
                        command.Parameters.AddWithValue("@Height", values[6]);
                        command.Parameters.AddWithValue("@HValue", values[7]);
                        command.Parameters.AddWithValue("@VValue", values[8]);

                        command.ExecuteNonQuery();
                    }
                }

                transaction.Commit();
            }
        }
      }



    }
