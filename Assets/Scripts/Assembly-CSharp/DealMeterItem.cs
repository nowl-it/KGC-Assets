using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DealMeterItem : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	public static int UniqueIdCounter;

	[ComponentConnect]
	public Text nameText;

	[ComponentConnect]
	public Text damageText;

	[ComponentConnect]
	public Image unitImage;

	[ComponentConnect]
	public Image gauge;

	[ComponentConnect]
	public Image gaugeSkill;

	[ComponentConnect]
	public Image gaugeItem;

	[ComponentConnect]
	public Image levelIcon;

	[ComponentConnect]
	public RogueLikeUnitLevel rogueLikeUnitLevel;

	public GameUnit target;

	public int id;

	public void Set(GameUnit target)
	{
	}

	public void UpdateDamage(float max, bool damageSum)
	{
	}

	private void SetDamageGauge(long damage, long skillDamage, long itemDamage, float max, bool damageSum)
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}
}
