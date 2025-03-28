using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarrackAltarBox : MonoBehaviour
{
	[SerializeField]
	private ConditionalImage _alterImage;

	[SerializeField]
	private ConditionalImage _alterLight;

	[SerializeField]
	private Transform[] _alterFlameRoots;

	[SerializeField]
	private Text[] _counts;

	private List<Animator> _flames;

	private List<int> _flameLevels;

	[SerializeField]
	private ConditionalImage _badge;

	public static BarrackAltarBox Instance => null;

	public void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void ReloadBadge()
	{
	}

	public void Reload()
	{
	}
}
