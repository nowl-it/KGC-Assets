using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class DeckResponseModel : ResponseModel
	{
		public DeckInfo[] deckInfos;

		public DefaultPotentialInfo defaultPotentialInfo;
	}
}
