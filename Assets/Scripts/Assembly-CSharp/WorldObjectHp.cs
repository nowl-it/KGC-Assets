using UnityEngine;

public class WorldObjectHp : MonoBehaviour
{
	public WorldObject target;

	public void Start()
	{
	}

	public virtual void OnChanged(int hp, int maxHp)
	{
	}
}
