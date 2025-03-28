using System;
using UnityEngine.Serialization;

namespace Awesomepiece.Model
{
	[Serializable]
	public class LoginSceneIllustDataResponseModel : ResponseModel
	{
		public string illust;

		public int x;

		public int y;

		public int rotation;

		public float scale;

		public string effectColor;

		public string bottomGradientColor;

		[FormerlySerializedAs("disableEffects")]
		public bool disableBGAndEffects;
	}
}
