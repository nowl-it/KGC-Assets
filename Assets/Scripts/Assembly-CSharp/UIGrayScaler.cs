using System.Collections.Generic;
using Coffee.UIEffects;
using UniRx;
using UnityEngine;

[ExecuteInEditMode]
public class UIGrayScaler : MonoBehaviour
{
	[SerializeField]
	private BoolReactiveProperty _set;

	[SerializeField]
	private BoolReactiveProperty _containsText;

	private List<UIEffect> _uiEffects;

	private bool _inited;

	public void SetGrayScale(bool set)
	{
	}
}
