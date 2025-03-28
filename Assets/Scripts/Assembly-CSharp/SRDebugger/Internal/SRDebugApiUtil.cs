using System.Net;

namespace SRDebugger.Internal
{
	public static class SRDebugApiUtil
	{
		public static string ParseErrorException(WebException ex)
		{
			return null;
		}

		public static string ParseErrorResponse(string response, string fallback = "Unexpected Response")
		{
			return null;
		}

		public static bool ReadResponse(HttpWebRequest request, out string result)
		{
			result = null;
			return false;
		}

		public static string ReadResponseStream(WebResponse stream)
		{
			return null;
		}
	}
}
