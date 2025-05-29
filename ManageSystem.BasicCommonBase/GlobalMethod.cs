using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.BasicCommonBase
{
    public class GlobalMethod
    {
        private const string KEY = "EC3DB9F032955C66F4856CDA3AD918D5D0BC8359219B8AD2AD87314EE46E59DA";
        private const string IV = "493370C020C37F740778B3CEFB462E4D";

        //Hex字符串转byte数组
        public static byte[] HexStringToBytes(string hexString)
        {
            byte[] bytes = new byte[hexString.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            }
            return bytes;
        }

        //byte数组转Hex字符串
        public static string BytesToHexString(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("X2"));
            }
            return sb.ToString().ToUpper();
        }

        // 加密
        public static string AESEncrypt(string plainText)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = HexStringToBytes(KEY);
                aes.IV = HexStringToBytes(IV);
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(plainText);
                        }
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        // 解密
        public static string AESDecrypt(string cipherText)
        {
            byte[] cipherBytes = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = HexStringToBytes(KEY);
                aes.IV = HexStringToBytes(IV);
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using (MemoryStream ms = new MemoryStream(cipherBytes))
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            return sr.ReadToEnd();
                        }
                    }
                }
            }
        }


        #region 机器码相关
        //注册码IV
        public const string SALT_VALUE = "CA8F4940EDF1482CAEB35BC1738BEDF9";
        public static string GetRegisterCode(int years)
        {
            string SystemLife =  DateTime.UtcNow.AddYears(years).ToString("yyyy/MM/dd");
            string CodeLife = DateTime.UtcNow.AddHours(1).ToString("yyyy/MM/dd");

            return $"{BytesToHexString(Encoding.UTF8.GetBytes(SystemLife))}"+
                   $"-{BytesToHexString(Encoding.UTF8.GetBytes(CodeLife))}"+
                   $"-{ComputeSha256Hash(GetMachineCode() + SALT_VALUE).ToUpper()}";
        }


        public static string GetMachineCode()
        {
            try
            {
                // 获取 CPU ID
                string cpuId = GetCpuId();
                // 获取第一个网卡的 MAC 地址
                string macAddress = GetMacAddress();
                // 获取硬盘序列号
                string diskSerialNumber = GetDiskSerialNumber();
                // 组合成机器码
                string machineInfo = $"{cpuId}-{macAddress}-{diskSerialNumber}";
                // 对组合后的信息进行哈希处理，得到固定长度的机器码
                string machineCode = ComputeSha256Hash(machineInfo);
                return machineCode.ToUpper();
            }
            catch (Exception ex)
            {
                Console.WriteLine("获取机器码时发生错误：" + ex.Message);
                return null;
            }
        }

        private static string GetCpuId()
        {
            string cpuId = string.Empty;
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    cpuId = obj["ProcessorId"]?.ToString() ?? "";
                    break;
                }
            }
            return cpuId;
        }

        private static string GetMacAddress()
        {
            string macAddress = string.Empty;
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT MACAddress FROM Win32_NetworkAdapter WHERE MACAddress IS NOT NULL"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    macAddress = obj["MACAddress"]?.ToString() ?? "";
                    break;
                }
            }
            return macAddress.Replace(":", "");
        }

        private static string GetDiskSerialNumber()
        {
            string diskSerialNumber = string.Empty;
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_PhysicalMedia"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    diskSerialNumber = obj["SerialNumber"]?.ToString() ?? "";
                    break;
                }
            }
            return diskSerialNumber.Trim();
        }

        public static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("X2"));
                }
                return builder.ToString().ToUpper();
            }
        }

        #endregion
    }
}
