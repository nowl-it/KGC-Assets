using UnityEngine;

public class RogueLikeEventPanelItem : MonoBehaviour
{
	[SerializeField]
	private ConditionalBase _selectedConditionals;

	protected ResourceRogueLikeEvent.Option _option;

	private RogueLikeEventPanel _eventPanel;

	public void SetEventOption(RogueLikeEventPanel panel, ResourceRogueLikeEvent.Option option)
	{
	}

	public virtual void SetSelected(int state)
	{
	}

	public virtual void OnClick()
	{
	}
}
