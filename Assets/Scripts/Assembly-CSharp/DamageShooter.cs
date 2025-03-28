using UnityEngine;
using UnityEngine.Rendering;

public class DamageShooter : MonoBehaviour
{
	private static DamageShooter _instance;

	public GameObject damagePrefab;

	public GameObjectPool damagePool;

	public DamageSprite playerDamage;

	public DamageSprite enemyDamage;

	public SerializedDictionary<DamageShootData.Type, DamageSprite> damagePairs;

	public Sprite criticalEffect;

	public bool active;

	public static DamageShooter Instance => null;

	public void Awake()
	{
	}

	public void ReloadActivation()
	{
	}

	public Damage Shoot(Vector2 pos, DamageShootData damageShootData, BattleManager battle, bool enemy = true, Damage chainParent = null)
	{
		return null;
	}

	public void Remove(Damage dmg)
	{
	}

	public DamageSprite GetTypeDamageSprite(DamageShootData.Type type)
	{
		return null;
	}
}
