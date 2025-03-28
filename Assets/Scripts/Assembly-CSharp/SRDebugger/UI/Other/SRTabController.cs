using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SRDebugger.UI.Controls;
using SRF;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Other
{
	public class SRTabController : SRMonoBehaviourEx
	{
		private readonly SRList<SRTab> _tabs;

		private SRTab _activeTab;

		[RequiredField]
		public RectTransform TabButtonContainer;

		[RequiredField]
		public SRTabButton TabButtonPrefab;

		[RequiredField]
		public RectTransform TabContentsContainer;

		[RequiredField]
		public RectTransform TabHeaderContentContainer;

		[RequiredField]
		public Text TabHeaderText;

		public SRTab ActiveTab
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IList<SRTab> Tabs => null;

		public event Action<SRTabController, SRTab> ActiveTabChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void AddTab(SRTab tab, bool visibleInSidebar = true)
		{
		}

		private void MakeActive(SRTab tab)
		{
		}

		private void SortTabs()
		{
		}
	}
}
