using UnityEngine;

[RequireComponent(typeof(Canvas))]
public class TabResponseCanvasOverrideSorting : TabResponse
{
	private Canvas _canvas;

	public bool overrideWhenSelected;

	public Canvas canvas => null;

	public override void SetSelected(bool v)
	{
	}
}
