using UnityEngine;

public class EffectArea : MonoBehaviour
{
	public class EffectAreaData
	{
		public int team;

		public int currentEffectCount;
	}

	[SerializeField]
	private SpriteRenderer _maskRenderer;

	[SerializeField]
	private SpriteRenderer _maskedRenderer;

	private EffectAreaData[] _effectAreaDataArray;

	public EffectAreaDrawer effectAreaDrawer { private get; set; }

	public void Initialize()
	{
	}

	public void AddEffect(int bitMaskIndex, int team)
	{
	}

	public void RemoveEffect(int bitMaskIndex)
	{
	}

	private void UpdateStencilRef()
	{
	}
}
