using UnityEngine;
using UnityEngine.UI;

public class DevOptionPanel : MonoBehaviour
{
	[ComponentConnect]
	public Toggle showMyTarget;

	[ComponentConnect]
	public Toggle showEnemyTarget;

	[ComponentConnect]
	public Toggle showMyPath;

	[ComponentConnect]
	public Toggle showEnemyPath;

	public void Awake()
	{
	}

	private void OnDestroy()
	{
	}
}
