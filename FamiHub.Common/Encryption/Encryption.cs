#region License
// *******************************************************
// Copyright (c) 2018 Famiflora SA
// 
// This file is part of FamiHub.
// FamiHub can not be copied and/or distributed without the express
// permission of Famiflora SA.
// *******************************************************
#endregion
using System;

namespace FamiHub.Common.Encryption
{
    public static class Encrypt
    {
        private static string encryptPassword = "FamiN1bjk0AwGjPlxRO8vCSwHub";
        public static string EncryptText(string input, string encryptionPassword = null)
        {
            if (encryptionPassword == null || encryptionPassword == "")
                encryptionPassword = encryptPassword;

            return Encryption.Cryptography.Encrypt(input, encryptionPassword);
        }
        public static string DecryptText(string input, string encryptionPassword = null)
        {
            if (encryptionPassword == null || encryptionPassword == "")
                encryptionPassword = encryptPassword;

            return Encryption.Cryptography.Decrypt(input, encryptionPassword);
        }
        public static byte[] EncryptByteArray(byte[] input, string encryptionPassword = null)
        {
            if (encryptionPassword == null || encryptionPassword == "")
                encryptionPassword = encryptPassword;

            return Encryption.Cryptography.Encrypt(input, encryptionPassword);
        }
        public static byte[] DecryptByteArray(byte[] input, string encryptionPassword = null)
        {
            if (encryptionPassword == null || encryptionPassword == "")
                encryptionPassword = encryptPassword;

            return Encryption.Cryptography.Decrypt(input, encryptionPassword);
        }
        public static string ConvertFromHexString(string input)
        {
            string stringValue = "";
            for (int i = 0; i < input.Length / 2; i++)
            {
                string hexChar = input.Substring(i * 2, 2);
                int hexValue = Convert.ToInt32(hexChar, 16);
                stringValue += Char.ConvertFromUtf32(hexValue);
            }
            return stringValue;
        }
        public static string ConvertToHexString(string input)
        {
            try
            {
                byte[] ba = System.Text.Encoding.Default.GetBytes(input);
                var hexString = BitConverter.ToString(ba);
                hexString = hexString.Replace("-", "");

                return hexString;
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                return null;
            }
        }
    }
}
