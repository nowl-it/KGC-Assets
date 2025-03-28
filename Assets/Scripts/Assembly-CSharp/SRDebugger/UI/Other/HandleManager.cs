using SRF;
using UnityEngine;

namespace SRDebugger.UI.Other
{
	public class HandleManager : SRMonoBehaviour
	{
		private bool _hasSet;

		public GameObject BottomHandle;

		public GameObject BottomLeftHandle;

		public GameObject BottomRightHandle;

		public PinAlignment DefaultAlignment;

		public GameObject LeftHandle;

		public GameObject RightHandle;

		public GameObject TopHandle;

		public GameObject TopLeftHandle;

		public GameObject TopRightHandle;

		private void Start()
		{
		}

		public void SetAlignment(PinAlignment alignment)
		{
		}

		private void SetActive(GameObject obj, bool active)
		{
		}
	}
}
