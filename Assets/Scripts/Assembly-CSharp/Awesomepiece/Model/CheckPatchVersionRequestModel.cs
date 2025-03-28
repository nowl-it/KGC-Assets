using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class CheckPatchVersionRequestModel
	{
		public string platform;

		public string version;

		public bool isDev;
	}
}
