using System;
using UnityEngine.Networking;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ResponseModel
	{
		public int code;

		public string msg;

		public UnityWebRequest www;

		public bool errorHandled;

		public string msg_ => null;

		public bool isSuccess => false;

		public void MakeFail(string failedMsg = "")
		{
		}
	}
}
