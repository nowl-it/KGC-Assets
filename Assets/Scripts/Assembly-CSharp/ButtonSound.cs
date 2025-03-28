using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler
{
	public enum Sound
	{
		se_button_click = 0,
		se_button_click_2 = 1,
		se_bag_open = 2,
		se_elite_set = 3,
		se_elite_open = 4,
		se_elite_button = 5,
		se_card_levelup_01 = 6,
		se_card_levelup_02 = 7,
		se_card_levelup_03 = 8,
		se_gacha_03 = 9,
		se_mode_normal = 10,
		se_mode_hard = 11,
		se_artifact_button_01 = 12,
		se_artifact_button_02 = 13,
		se_artifact_button_03 = 14,
		se_artifact_set = 15,
		se_sanctuary_reset = 16,
		se_teleport_start = 17,
		se_teleport_end = 18,
		se_elite_done = 19,
		se_button_click_3 = 20,
		se_button_click_4 = 21,
		se_move_footstap = 22,
		se_rune = 23,
		se_elite_set_roguelike = 24,
		se_select_treasure = 25,
		se_select_accessory = 26
	}

	public enum Phase
	{
		Click = 0,
		Down = 1
	}

	public Sound sound;

	public Phase phase;

	private Button _button;

	public bool ignoreInteractable;

	private void Awake()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}

	public void PlaySound()
	{
	}
}
