using UnityEngine;
using UnityEngine.UI;

public class MultiImageButton : Button
{
	private Graphic[] m_graphics;

	protected Graphic[] Graphics => null;

	protected override void DoStateTransition(SelectionState state, bool instant)
	{
	}

	private void ColorTween(Color targetColor, bool instant)
	{
	}
}
