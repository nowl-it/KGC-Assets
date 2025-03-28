using UnityEngine;
using UnityEngine.UI;

public class TerritoryStatBuffDisplayer : MonoBehaviour
{
	[SerializeField]
	private Text _atkText;

	[SerializeField]
	private Text _matkText;

	[SerializeField]
	private Text _atkSpeedText;

	[SerializeField]
	private Text _hpText;

	public void SetMyStatBuffs()
	{
	}

	public void SetOtherPlayerStatBuffs(float[] buffs)
	{
	}

	public void SetOtherPlayerStatBuffs(int[] buffs)
	{
	}

	private void SetImpl(float[] buffs)
	{
	}
}
