using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wisej.Hybrid;

namespace HybridLocal.Services
{
	internal class UserService
	{
		private readonly string _userName;
		private readonly string _documentsDirectory;

		public UserService(string username) 
		{ 
			this._userName = username;
			this._documentsDirectory = Path.Combine(Device.Info.FileSystem.LocalApplicationData, "Documents", username);
		}

		public string[] GetUserDocuments(string searchPattern)
		{
			var files = new string[0];

			if (Directory.Exists(this._documentsDirectory))
			{
				files = Directory.GetFiles(this._documentsDirectory, searchPattern);
			}

			return files;
		}

		public void SaveUserDocument(string fileName, byte[] contents)
		{
			if (!Directory.Exists(this._documentsDirectory))
				Directory.CreateDirectory(this._documentsDirectory);


		}
	}
}
