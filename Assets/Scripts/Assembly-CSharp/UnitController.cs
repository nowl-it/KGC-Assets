using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class UnitController : MonoBehaviour, IPostAddressableProcessed
{
	public int unitId;

	public Animator animator;

	public GameUnit target;

	public Transform positionRoot;

	public SpriteRenderer shadow;

	public Collider2D attackCollider;

	public Transform shootPoint;

	public Transform[] particleRoots;

	public Transform[] effectRoot;

	public SpriteRenderer[] sprites;

	private readonly List<Tweener> _spriteColorTweens;

	private readonly List<Tweener> _spriteAlphaTweens;

	public Transform torso;

	private float _goalAngle;

	private float _displayAngle;

	protected float _prevSpeed;

	private float _idleTimer;

	private bool _isRunning;

	private float _nextSpeedUpAfterimageEffectAt;

	private bool _attackEndIdle;

	private Color _shootColorLastColor;

	private bool _shootColorLashWithShadow;

	private float _shootColorKeepTimer;

	private float _shootColorRestoreTimer;

	private bool _isUI;

	public bool pauseUpdateUI;

	private SpriteSheetController _sheetController;

	private Dictionary<int, bool> paramDict;

	private Transform _originShootPoint;

	public static readonly int DirBlendKey;

	public static readonly int BuffBlendKey;

	public static readonly int IdleKey;

	public static readonly int RunKey;

	public static readonly int AttackKey;

	public static readonly int SkillKey;

	public static readonly int CancelKey;

	public static readonly int EffectKey;

	public static readonly int IsRunKey;

	public static readonly int AttackSpeedFloatKey;

	public static readonly int SkillSpeedFloatKey;

	public static readonly int MoveSpeedFloatKey;

	public static readonly int ReviveKey;

	public static readonly int AttackIntKey;

	public static readonly int SkillIntKey;

	public static readonly int TierIntKey;

	public static readonly int StackIntKey;

	public static readonly int BuffEndTrigger;

	public static readonly int EndTrigger;

	public static readonly int ShootTrigger;

	public static readonly int IsFullStackKey;

	public static readonly int KillIntKey;

	private static ulong _shootColorRestoreHash;

	private List<(SpriteRenderer, Image)> _spriteImagePair;

	public List<GameObject> attachedUnitEffects;

	public List<SpriteRenderer> attachedUnitEffectRenderers;

	public GameObject actorImage;

	public SpriteSheetController sheetController => null;

	public void Start()
	{
	}

	public bool HasDirection()
	{
		return false;
	}

	public void SetDirection(int dir)
	{
	}

	public void SetRun()
	{
	}

	public void SetIdle(float delay = 0f)
	{
	}

	public void Cancel()
	{
	}

	public void Attack()
	{
	}

	public void Skill()
	{
	}

	public void ResetAttackTrigger()
	{
	}

	public void Effect()
	{
	}

	public void Damaged()
	{
	}

	public void DamagedEnd()
	{
	}

	public void Die()
	{
	}

	public void ShootSkill()
	{
	}

	public void SkillEnd()
	{
	}

	public void SetAttackSpeed(float speed)
	{
	}

	public void SetSkillSpeed(float speed)
	{
	}

	public void SetMoveSpeed(float speed)
	{
	}

	public void Empty()
	{
	}

	public void SetTrigger(string trigger)
	{
	}

	public void SetTrigger(int trigger)
	{
	}

	public void SetTriggerWithCheck(int key)
	{
	}

	public void DOColor(Color color, float time, float keepTime = 0f, Action onComplete = null, bool withAlpha = false)
	{
	}

	public void ShootColor(Color color, float keepTime, float restoreTime, bool withShadow = false)
	{
	}

	public Color GetColor()
	{
		return default(Color);
	}

	public void RestoreColor(Color srcColor, Color destColor, bool tween = false, float tweenTime = 0f, bool withShadow = false)
	{
	}

	public void SetColor(Color destColor)
	{
	}

	public void DOFade(float alpha, float time, Action onComplete, float delay = 0f)
	{
	}

	public void FadeForGachaNewUnitPanel()
	{
	}

	public void AnimEvent(string eventName)
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	public void SetTorsoAngle(float angle)
	{
	}

	public void Update()
	{
	}

	public void FixedUpdate()
	{
	}

	private void UpdateImpl(bool useFixedUpdate)
	{
	}

	public void ShowAfterImage()
	{
	}

	public void SetSpriteOrder(int order)
	{
	}

	public void SetSkillEffectsEnable(bool v)
	{
	}

	public void AddIntParam(string param, int value, int max)
	{
	}

	public void ResetIdleTimer()
	{
	}

	public void SetupUI(bool animatorEnabled = true, bool withShadow = false, bool withFrameAnimation = true, bool maskable = true)
	{
	}

	public void UpdateUI()
	{
	}

	public void SetAttackEndIdle(bool v)
	{
	}

	public void SetAttackInt(int v)
	{
	}

	public void SetSkillInt(int v)
	{
	}

	public int GetSkillInt()
	{
		return 0;
	}

	public void SetTierInt(int v)
	{
	}

	public void SetIsFullStackBool(bool v)
	{
	}

	public void SetKillInt(int v)
	{
	}

	private bool HasParameter(int key)
	{
		return false;
	}

	public void SetEffectRootActive(bool set)
	{
	}

	public void ChangeShootPoint(string name)
	{
	}

	public void ResetShootPoint()
	{
	}

	public void OnPostAddressableProcessed()
	{
	}
}
