using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class IAPBuyRequestModel
	{
		public int itemId;

		public int unitId;

		public string transactionId;

		public string receipt;

		public string signedData;

		public string signature;

		public string store;

		public bool forceRestore;
	}
}
