using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class PatchFolderRequestModel
	{
		public string platform;

		public string version;

		public bool isDev;
	}
}
