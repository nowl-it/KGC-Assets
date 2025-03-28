using System.Collections.Generic;
using SRF.Service;

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(ISystemInformationService))]
	public class StandardSystemInformationService : ISystemInformationService
	{
		private readonly Dictionary<string, IList<InfoEntry>> _info;

		public IEnumerable<string> GetCategories()
		{
			return null;
		}

		public IList<InfoEntry> GetInfo(string category)
		{
			return null;
		}

		public void Add(InfoEntry info, string category = "Default")
		{
		}

		public Dictionary<string, Dictionary<string, object>> CreateReport(bool includePrivate = false)
		{
			return null;
		}

		private void CreateDefaultSet()
		{
		}

		private static string GetCloudManifestPrettyName(string name)
		{
			return null;
		}
	}
}
