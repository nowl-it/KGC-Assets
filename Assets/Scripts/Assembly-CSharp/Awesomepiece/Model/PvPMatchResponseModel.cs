using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class PvPMatchResponseModel : ResponseModel
	{
		public PvPDeckInfo[] targets;
	}
}
