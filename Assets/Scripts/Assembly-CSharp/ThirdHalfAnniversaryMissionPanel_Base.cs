using System;
using UnityEngine;
using UnityEngine.UI;

public class ThirdHalfAnniversaryMissionPanel_Base : MissionPanel_Base
{
	[SerializeField]
	private HorizontalLayoutGroup _tabLayout;

	[SerializeField]
	private ScrollRect _tabScrollRect;

	[SerializeField]
	private Text _eventTimeLeftText;

	private DateTime _eventUntilAt;

	private bool _untilAtInitialized;

	private bool _isEventEnd;

	private RectTransform _tabLayoutRectTransform => null;

	private RectTransform _scrollRectTransform => null;

	private Vector2 _layoutRightEndPos => default(Vector2);

	public void OnClickMoveTab(bool right)
	{
	}

	public void ReloadTableView()
	{
	}

	private void OnEventEnd()
	{
	}

	private void Update()
	{
	}
}
