using System;
using System.Collections.Generic;
using System.ComponentModel;
using SRDebugger.Internal;
using SRDebugger.Services;
using SRDebugger.UI.Controls;
using SRDebugger.UI.Controls.Data;
using SRDebugger.UI.Other;
using SRF;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Tabs
{
	public class OptionsTabController : SRMonoBehaviourEx
	{
		private class CategoryInstance
		{
			public readonly List<OptionsControlBase> Options;

			public CategoryGroup CategoryGroup { get; private set; }

			public CategoryInstance(CategoryGroup group)
			{
			}
		}

		private readonly List<OptionsControlBase> _controls;

		private readonly List<CategoryInstance> _categories;

		private readonly Dictionary<OptionDefinition, OptionsControlBase> _options;

		private bool _queueRefresh;

		private bool _selectionModeEnabled;

		private Canvas _optionCanvas;

		[RequiredField]
		public ActionControl ActionControlPrefab;

		[RequiredField]
		public CategoryGroup CategoryGroupPrefab;

		[RequiredField]
		public RectTransform ContentContainer;

		[RequiredField]
		public GameObject NoOptionsNotice;

		[RequiredField]
		public Toggle PinButton;

		[RequiredField]
		public GameObject PinPromptSpacer;

		[RequiredField]
		public GameObject PinPromptText;

		private bool _isTogglingCategory;

		protected override void Start()
		{
		}

		private void OnOptionPinnedStateChanged(OptionDefinition optionDefinition, bool isPinned)
		{
		}

		private void OnOptionsUpdated(object sender, EventArgs eventArgs)
		{
		}

		private void OnOptionsValueChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void Update()
		{
		}

		private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b)
		{
		}

		public void SetSelectionModeEnabled(bool isEnabled)
		{
		}

		private void Refresh()
		{
		}

		private void CommitPinnedOptions()
		{
		}

		private void RefreshCategorySelection()
		{
		}

		private void OnOptionSelectionToggle(bool selected)
		{
		}

		private void OnCategorySelectionToggle(CategoryInstance category, bool selected)
		{
		}

		protected void Populate()
		{
		}

		protected void CreateCategory(string title, List<OptionDefinition> options)
		{
		}

		private void Clear()
		{
		}
	}
}
