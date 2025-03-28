using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ServerData
	{
		public string name;

		public string url;

		public CachedServerUpdateInfo cachedInfo;
	}
}
