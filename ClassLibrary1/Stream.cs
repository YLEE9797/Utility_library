using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLib
{
    internal class Stream
    {
        public static GZipStream zip;
        public static byte[] deliverbyte;
        #region 문자열 변환(byte ->string)
        //byte 로 밭은 데이터를 문자열로 변환
        static byte[] StreamByte(byte[]Streambyte)
      {
            Streambyte = new byte[200];
            for(int i = 0; i < Streambyte.Length; i++)
            {
                Streambyte[i] = (byte)(char)Streambyte[i];
            }
            return Streambyte;
      }
        #endregion
        delegate Stream StreamFactory();
        //byte 데이터 표시하기
        #region byte 데이터 표시
        static MemoryStream GenerateData()
        {
            byte[] buffer = new byte[16];
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = (byte)i;
            }
            return new MemoryStream(buffer);
        }
        #endregion
        #region 파일 압축
        //파일 압축하기
        static void BackUpFile(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                throw new Exception("파일이 존재합니다!.파일을 확인 해주세요");
            }
            else
            {
                Directory.CreateDirectory(FilePath);
                File.Create(FilePath);
                StreamByte(deliverbyte);
                zip.Write(deliverbyte,0,200);
            }
        }
        #endregion

    }
}
