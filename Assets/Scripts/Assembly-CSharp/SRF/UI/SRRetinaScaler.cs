using UnityEngine;
using UnityEngine.UI;

namespace SRF.UI
{
	[AddComponentMenu("SRF/UI/Retina Scaler")]
	[RequireComponent(typeof(CanvasScaler))]
	public class SRRetinaScaler : SRMonoBehaviour
	{
		[SerializeField]
		private float _retinaScale;

		[SerializeField]
		private int _thresholdDpi;

		[SerializeField]
		private bool _disablePixelPerfect;

		public int ThresholdDpi => 0;

		public float RetinaScale => 0f;

		private void Start()
		{
		}
	}
}
