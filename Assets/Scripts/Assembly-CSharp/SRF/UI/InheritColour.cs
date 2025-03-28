using UnityEngine;
using UnityEngine.UI;

namespace SRF.UI
{
	[RequireComponent(typeof(Graphic))]
	[ExecuteInEditMode]
	[AddComponentMenu("SRF/UI/Inherit Colour")]
	public class InheritColour : SRMonoBehaviour
	{
		private Graphic _graphic;

		public Graphic From;

		private Graphic Graphic => null;

		private void Refresh()
		{
		}

		private void Update()
		{
		}

		private void Start()
		{
		}
	}
}
