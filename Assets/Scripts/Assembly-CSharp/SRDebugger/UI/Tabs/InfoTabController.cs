using System.Collections.Generic;
using SRDebugger.UI.Controls;
using SRF;
using UnityEngine;

namespace SRDebugger.UI.Tabs
{
	public class InfoTabController : SRMonoBehaviourEx
	{
		public const char Tick = '✓';

		public const char Cross = '×';

		public const string NameColor = "#BCBCBC";

		private Dictionary<string, InfoBlock> _infoBlocks;

		[RequiredField]
		public InfoBlock InfoBlockPrefab;

		[RequiredField]
		public RectTransform LayoutContainer;

		protected override void OnEnable()
		{
		}

		public void Refresh()
		{
		}

		private void FillInfoBlock(InfoBlock block, IList<InfoEntry> info)
		{
		}

		private InfoBlock CreateBlock(string title)
		{
			return null;
		}
	}
}
