using System;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScrollRectEx : ScrollRect
{
	private bool routeToParent;

	public Action<PointerEventData> onBeginDrag;

	public Action<PointerEventData> onDrag;

	public Action<PointerEventData> onEndDrag;

	private void DoForParents<T>(Action<T> action) where T : IEventSystemHandler
	{
	}

	public override void OnInitializePotentialDrag(PointerEventData eventData)
	{
	}

	public override void OnDrag(PointerEventData eventData)
	{
	}

	public override void OnBeginDrag(PointerEventData eventData)
	{
	}

	public override void OnEndDrag(PointerEventData eventData)
	{
	}
}
