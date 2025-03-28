using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class CardListResponseModel : ResponseModel
	{
		public List<CardResponseModel> cards;
	}
}
