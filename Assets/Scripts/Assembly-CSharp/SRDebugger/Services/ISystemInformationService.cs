using System.Collections.Generic;

namespace SRDebugger.Services
{
	public interface ISystemInformationService
	{
		IEnumerable<string> GetCategories();

		IList<InfoEntry> GetInfo(string category);

		void Add(InfoEntry info, string category = "Default");

		Dictionary<string, Dictionary<string, object>> CreateReport(bool includePrivate = false);
	}
}
