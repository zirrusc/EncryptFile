using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace EncryptFile
{
	class Encrypt
	{
		public const string EncryptExtension = ".encrypt";

		private static void GenerateKeyFromPassword(string password, int keysize, out byte[] key, int blocksize, out byte[] iv)
		{
			byte[] salt = Encoding.UTF8.GetBytes("eRz28JLnMT5uxDvkdwdwyowvsUVh76bD6YAZqoaGvENugvZatiN3uvNWTOd6ZqfCQ94R1ofVR5ct3mik1Lysv4p3sBByU8Lc2VKa4snXCnl6eBMvh8cOT8UY7Y6Rq7Ty");
			Rfc2898DeriveBytes deriveBytes = new Rfc2898DeriveBytes(password, salt);
			deriveBytes.IterationCount = 1000;
			key = deriveBytes.GetBytes(keysize / 8);
			iv = deriveBytes.GetBytes(blocksize / 8);
		}

		public static void EncryptFile(string sourceFile, string destFile, string password)
		{
			RijndaelManaged rijndael = null;
			byte[] key, iv;
			FileStream outfs = null;
			ICryptoTransform encryptor = null;
			CryptoStream cryptostream = null;
			FileStream infs = null;
			try
			{
				rijndael = new RijndaelManaged();
				GenerateKeyFromPassword(password, rijndael.KeySize, out key, rijndael.BlockSize, out iv);
				rijndael.Key = key;
				rijndael.IV = iv;

				outfs = new FileStream(destFile, FileMode.Create, FileAccess.Write);
				encryptor = rijndael.CreateEncryptor();
				cryptostream = new CryptoStream(outfs, encryptor, CryptoStreamMode.Write);
				infs = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
				byte[] bs = new byte[1024];
				int readLen;
				while ((readLen = infs.Read(bs, 0, bs.Length)) > 0)
				{
					cryptostream.Write(bs, 0, readLen);
				}
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				if (rijndael != null) rijndael.Dispose();
				if (infs != null) infs.Dispose();
				if (cryptostream != null) cryptostream.Close();
				if (encryptor != null) encryptor.Dispose();
				if (outfs != null) outfs.Dispose();
			}
		}

		public static void DecryptFile(string sourceFile, string destFile, string password)
		{
			RijndaelManaged rijndael = null;
			byte[] key, iv;
			FileStream infs = null;
			ICryptoTransform decryptor = null;
			CryptoStream cryptostream = null;
			FileStream outfs = null;
			byte[] bs = null;

			try
			{
				rijndael = new RijndaelManaged();

				GenerateKeyFromPassword(password, rijndael.KeySize, out key, rijndael.BlockSize, out iv);
				rijndael.Key = key;
				rijndael.IV = iv;

				infs = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
				decryptor = rijndael.CreateDecryptor();
				cryptostream = new CryptoStream(infs, decryptor, CryptoStreamMode.Read);

				outfs = new FileStream(destFile, FileMode.Create, FileAccess.Write);
				bs = new byte[1024];
				int readLen;
				while ((readLen = cryptostream.Read(bs, 0, bs.Length)) > 0)
				{
					outfs.Write(bs, 0, readLen);
				}
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				if (outfs != null) outfs.Close();
				if (cryptostream != null) cryptostream.Close();
				if (decryptor != null) decryptor.Dispose();
				if (infs != null) infs.Close();
			}
		}
	}
}
