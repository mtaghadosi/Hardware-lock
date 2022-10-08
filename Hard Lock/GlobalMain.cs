using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Management;
using Microsoft.Win32;
using System.Security.Cryptography;

namespace Hard_Lock
{
    //created by mohammad taghadosi
    class GlobalMain
    {
        //this codes disables the form's close bottons created by M.Taghadosi...
        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32.dll")]
        private static extern int EnableMenuItem(IntPtr hMenu, int wIDEnableItem, int wEnable);
        /// <summary>
        /// this methode disables the form's close botton
        /// </summary>
        /// <param name="a">please write this.Handle</param>
        /// <param name="b">Please Write False</param>
        /// <param name="SC_CLOSE">Please Write 0xF060</param>
        /// <param name="MF_GRAYED">Please Write 0x1</param>
        public static void DisableCloseBotton(IntPtr a, bool b, int SC_CLOSE, int MF_GRAYED)
        {
            EnableMenuItem(GetSystemMenu(a, b), SC_CLOSE, MF_GRAYED);
        }

        /// <summary>
        /// this methode gets the CPU Unique ID Creaated by mohammad taghadosi
        /// </summary>
        /// <returns></returns>
        public static string GetCPUId()
        {
            string cpuInfo = String.Empty;
            //create an instance of the Managemnet class with the
            //Win32_Processor class
            ManagementClass mgmt = new ManagementClass("Win32_Processor");
            //create a ManagementObjectCollection to loop through
            ManagementObjectCollection objCol = mgmt.GetInstances();
            //start our loop for all processors found
            foreach (ManagementObject obj in objCol)
            {
                if (cpuInfo == String.Empty)
                {
                    // only return cpuInfo from first CPU
                    cpuInfo = obj.Properties["ProcessorId"].Value.ToString();
                }
            }
            return cpuInfo;
        }

        /// <summary>
        /// this code returns the cpu manufacturer by mohammad taghadosi
        /// </summary>
        /// <returns></returns>
        public static string GetCPUManufacturer()
        {
            string cpuMan = String.Empty;
            //create an instance of the Managemnet class with the
            //Win32_Processor class
            ManagementClass mgmt = new ManagementClass("Win32_Processor");
            //create a ManagementObjectCollection to loop through
            ManagementObjectCollection objCol = mgmt.GetInstances();
            //start our loop for all processors found
            foreach (ManagementObject obj in objCol)
            {
                if (cpuMan == String.Empty)
                {
                    // only return manufacturer from first CPU
                    cpuMan = obj.Properties["Manufacturer"].Value.ToString();
                }
            }
            return cpuMan;
        }

        /// <summary>
        /// get the LAN MAC Address By mohammad taghadosi
        /// </summary>
        public static string GetMACAddress()
        {
            string  Mac_Address= string.Empty;
            ManagementObjectSearcher searcher;
            string qry = "select * FROM Win32_NetworkAdapter";
            searcher = new ManagementObjectSearcher(qry);
            foreach (ManagementObject wmi_HD in searcher.Get())
                if (wmi_HD["MacAddress"] != null)
                    Mac_Address = wmi_HD["MacAddress"].ToString();
            return Mac_Address;
        }



        /// <summary>
        /// write Coded lock_string into the registry...
        /// </summary>
        /// <param name="_value"></param>
        public static void WriteRegistryConfig_ForLockString(string _value)
        {
            string Coded = EncryptAndDecrypt(_value, "encrypt", "m.taghadosi");
            string _name = "LockString";
            RegistryKey ADD_ConfigKey = Registry.LocalMachine.CreateSubKey(@"Software\Parking", RegistryKeyPermissionCheck.ReadWriteSubTree);
            ADD_ConfigKey.SetValue(_name, Coded);
        }

        /// <summary>
        /// this methode is for Encoding and Decoding connectionstring for more Security
        /// have 3 input "first input must be encrypted or decrypted connectionstring"
        /// and 2nd must be "encrypt" for Encrypting and "decrypt" for Decrypting.
        /// this encrypting algorithm works on TDES powerfull string coding algorithem
        /// the 3nd input, is an input key for this algorithm (created by m.taghadosi)
        /// </summary>
        /// <param name="_orginal"></param>
        /// <param name="_str"></param>
        /// <returns></returns>
        public static string EncryptAndDecrypt(string _original, string _str, string _TDESAlgorithem)
        {
            _str = _str.ToLower();
            if (_str == "encrypt")
            {
                byte[] _results;
                UTF8Encoding utf8 = new UTF8Encoding();
                MD5CryptoServiceProvider md = new MD5CryptoServiceProvider();
                byte[] TDESKey = md.ComputeHash(utf8.GetBytes(_TDESAlgorithem)); //algorithem's key, m.taghadosi
                byte[] _data = utf8.GetBytes(_original); //algorithem's input array, m.taghadosi

                TripleDESCryptoServiceProvider TDESAlgorithem = new TripleDESCryptoServiceProvider();
                TDESAlgorithem.Key = TDESKey;
                TDESAlgorithem.Mode = CipherMode.ECB;
                TDESAlgorithem.Padding = PaddingMode.PKCS7;

                try
                {
                    ICryptoTransform encryptor = TDESAlgorithem.CreateEncryptor();
                    _results = encryptor.TransformFinalBlock(_data, 0, _data.Length);
                }
                finally
                {
                    TDESAlgorithem.Clear();
                    md.Clear();
                }
                return Convert.ToBase64String(_results);
            }
            if (_str == "decrypt")
            {
                byte[] _result;
                UTF8Encoding utf8 = new UTF8Encoding();
                MD5CryptoServiceProvider md = new MD5CryptoServiceProvider();
                byte[] TDESKey = md.ComputeHash(utf8.GetBytes(_TDESAlgorithem)); //algorithem's key, m.taghadosi
                byte[] _data = Convert.FromBase64String(_original);

                TripleDESCryptoServiceProvider decryptor = new TripleDESCryptoServiceProvider();
                decryptor.Key = TDESKey;
                decryptor.Mode = CipherMode.ECB;
                decryptor.Padding = PaddingMode.PKCS7;

                try
                {
                    ICryptoTransform transform = decryptor.CreateDecryptor();
                    _result = transform.TransformFinalBlock(_data, 0, _data.Length);
                }
                finally
                {
                    decryptor.Clear();
                    md.Clear();
                }
                return utf8.GetString(_result);
            }
            return "Error On Decode or Encoding!";
        }

        /// <summary>
        /// indicates that the software is installed in this system or not 
        /// </summary>
        /// <returns></returns>
        public static bool IsSoftwareInstalled()
        {
            if (Registry.LocalMachine.OpenSubKey(@"Software\Parking", true) != null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// checks that the lock key is located or not
        /// </summary>
        /// <returns></returns>
        public static bool IsKeyLocated()
        {
            string[] str = new string[100];
            if (Registry.LocalMachine.OpenSubKey(@"Software\Parking", true) != null)
            {

                str = Registry.LocalMachine.OpenSubKey(@"Software\Parking", true).GetValueNames();
                foreach(string a in str)
                {
                    if (a == "LockString")
                        return true;
                    else
                        return false;
                }
            }
            else
                return false;
            return false;
        }
        public static bool ClearRegistryKey ()
        {
            try
            {
                Registry.LocalMachine.OpenSubKey(@"Software\Parking", true).DeleteValue("LockString", true);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
    }
}
