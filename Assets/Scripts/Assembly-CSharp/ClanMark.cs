using UnityEngine;
using UnityEngine.UI;

public class ClanMark : MonoBehaviour
{
	public ConditionalImage frameImage;

	public Image markImage;

	[HideInInspector]
	public int markId;

	public void Set(int id, int frame = 0)
	{
	}
}
