using System;
using UnityEngine;

// Token: 0x020000F5 RID: 245
public class PrefabCache : MonoBehaviour
{
	// Token: 0x060006AA RID: 1706 RVA: 0x0001FD84 File Offset: 0x0001DF84
	public static void init()
	{
		if (PrefabCache.instance == null)
		{
			GameObject gameObject = new GameObject();
			gameObject.AddComponent<PrefabCache>();
			gameObject.name = "Prefab Cache";
			UnityEngine.Object.Instantiate<GameObject>(gameObject);
			PrefabCache.queueObject = new GameObject[16];
			PrefabCache.load();
		}
	}

	// Token: 0x060006AB RID: 1707 RVA: 0x0001FDD4 File Offset: 0x0001DFD4
	public static void load()
	{
		PrefabCache.GoldDrop = Resources.Load<GameObject>("GoldDrop");
		PrefabCache.ExpDrop = Resources.Load<GameObject>("ExpDrop");
		PrefabCache.prefabs = new GameObject[16];
		PrefabCache.prefabs[0] = Resources.Load<GameObject>("Units/Clubman");
		PrefabCache.prefabs[1] = Resources.Load<GameObject>("Units/Slignshot");
		PrefabCache.prefabs[2] = Resources.Load<GameObject>("Units/Dinorider");
		PrefabCache.prefabs[3] = Resources.Load<GameObject>("Units/Swordsman");
		PrefabCache.prefabs[4] = Resources.Load<GameObject>("Units/SwordsmanArbalite");
		PrefabCache.prefabs[5] = Resources.Load<GameObject>("Units/Knight");
		PrefabCache.prefabs[6] = Resources.Load<GameObject>("Units/Dueler");
		PrefabCache.prefabs[7] = Resources.Load<GameObject>("Units/Rifleman");
		PrefabCache.prefabs[8] = Resources.Load<GameObject>("Units/Canoneer");
		PrefabCache.prefabs[9] = Resources.Load<GameObject>("Units/ModernMelee");
		PrefabCache.prefabs[10] = Resources.Load<GameObject>("Units/ModernRanged");
		PrefabCache.prefabs[11] = Resources.Load<GameObject>("Units/Tank");
		PrefabCache.prefabs[12] = Resources.Load<GameObject>("Units/FuturisticWarrior");
		PrefabCache.prefabs[13] = Resources.Load<GameObject>("Units/FuturisticRanged");
		PrefabCache.prefabs[14] = Resources.Load<GameObject>("Units/FuturisticTank");
		PrefabCache.prefabs[15] = Resources.Load<GameObject>("Units/FuturisticSuper");
		PrefabCache.particles = new GameObject[16];
		PrefabCache.particles[1] = Resources.Load<GameObject>("Particles/Part1");
		PrefabCache.particles[2] = Resources.Load<GameObject>("Particles/Part2");
		PrefabCache.particles[3] = Resources.Load<GameObject>("Particles/Part3");
		PrefabCache.particles[4] = Resources.Load<GameObject>("Particles/Part4");
		PrefabCache.particles[5] = Resources.Load<GameObject>("Particles/Part5");
		PrefabCache.particles[6] = Resources.Load<GameObject>("Particles/Part6");
		PrefabCache.particles[7] = Resources.Load<GameObject>("Particles/Part7");
		PrefabCache.particles[8] = Resources.Load<GameObject>("Particles/Part8");
		PrefabCache.particles[9] = Resources.Load<GameObject>("Particles/Part9");
		PrefabCache.particles[10] = Resources.Load<GameObject>("Particles/Part10");
		PrefabCache.particles[11] = Resources.Load<GameObject>("Particles/Part11");
		PrefabCache.particles[12] = Resources.Load<GameObject>("Particles/Part12");
		PrefabCache.particles[13] = Resources.Load<GameObject>("Particles/Part13");
		PrefabCache.particles[14] = Resources.Load<GameObject>("Particles/Part14");
		PrefabCache.LoadingScreen = Resources.Load<GameObject>("Loading");
		PrefabCache.Coin = Resources.Load<GameObject>("Coin");
		PrefabCache.Exp = Resources.Load<GameObject>("Exp");
		PrefabCache.Aura = Resources.Load<GameObject>("Aura");
		PrefabCache.Bomb = Resources.Load<GameObject>("Specials/Bomb");
		PrefabCache.BeamCircle = Resources.Load<GameObject>("Specials/BeamCircle");
		PrefabCache.deathClips = new AudioClip[3];
		PrefabCache.deathClips[0] = (AudioClip)Resources.Load("Sounds/dead0");
		PrefabCache.deathClips[1] = (AudioClip)Resources.Load("Sounds/dead2");
		PrefabCache.deathClips[2] = (AudioClip)Resources.Load("Sounds/dead5");
		PrefabCache.hitClips = new AudioClip[2];
		PrefabCache.hitClips[0] = (AudioClip)Resources.Load("Sounds/damadge_hit1");
		PrefabCache.hitClips[1] = (AudioClip)Resources.Load("Sounds/damadge_hit2");
		PrefabCache.buttonClip = (AudioClip)Resources.Load("Sounds/button6");
		PrefabCache.queueObject[0] = Resources.Load<GameObject>("Hud/Queue/queueIcons_0");
		PrefabCache.queueObject[1] = Resources.Load<GameObject>("Hud/Queue/queueIcons_1");
		PrefabCache.queueObject[2] = Resources.Load<GameObject>("Hud/Queue/queueIcons_2");
		PrefabCache.queueObject[3] = Resources.Load<GameObject>("Hud/Queue/queueIcons_3");
		PrefabCache.queueObject[4] = Resources.Load<GameObject>("Hud/Queue/queueIcons_4");
		PrefabCache.queueObject[5] = Resources.Load<GameObject>("Hud/Queue/queueIcons_5");
		PrefabCache.queueObject[6] = Resources.Load<GameObject>("Hud/Queue/queueIcons_6");
		PrefabCache.queueObject[7] = Resources.Load<GameObject>("Hud/Queue/queueIcons_7");
		PrefabCache.queueObject[8] = Resources.Load<GameObject>("Hud/Queue/queueIcons_8");
		PrefabCache.queueObject[9] = Resources.Load<GameObject>("Hud/Queue/queueIcons_9");
		PrefabCache.queueObject[10] = Resources.Load<GameObject>("Hud/Queue/queueIcons_10");
		PrefabCache.queueObject[11] = Resources.Load<GameObject>("Hud/Queue/queueIcons_11");
		PrefabCache.queueObject[12] = Resources.Load<GameObject>("Hud/Queue/queueIcons_12");
		PrefabCache.queueObject[13] = Resources.Load<GameObject>("Hud/Queue/queueIcons_13");
		PrefabCache.queueObject[14] = Resources.Load<GameObject>("Hud/Queue/queueIcons_14");
		PrefabCache.queueObject[15] = Resources.Load<GameObject>("Hud/Queue/queueIcons_15");
		PrefabCache.buildTurretSound = (AudioClip)Resources.Load("Sounds/buildTurret");
		PrefabCache.finalUpgrade = (AudioClip)Resources.Load("Sounds/finalUpgrade");
		PrefabCache.beam = (AudioClip)Resources.Load("Sounds/beam");
		PrefabCache.SpecialsComet = Resources.Load<GameObject>("Specials/SpecialComets");
		PrefabCache.SpecialsArrow = Resources.Load<GameObject>("Specials/SpecialArrows");
		PrefabCache.SpecialsHeal = Resources.Load<GameObject>("Specials/SpecialHeal");
		PrefabCache.SpecialsBomber = Resources.Load<GameObject>("Specials/SpecialBomber");
		PrefabCache.SpecialsBeam = Resources.Load<GameObject>("Specials/SpecialBeam");
		PrefabCache.Comet = Resources.Load<GameObject>("Specials/Comet");
		PrefabCache.Arrow = Resources.Load<GameObject>("Specials/Arrows");
	}

	// Token: 0x060006AC RID: 1708 RVA: 0x00020404 File Offset: 0x0001E604
	private void Start()
	{
		if (PrefabCache.instance == null)
		{
			PrefabCache.instance = this;
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0400042C RID: 1068
	public static PrefabCache instance;

	// Token: 0x0400042D RID: 1069
	public static GameObject[] prefabs;

	// Token: 0x0400042E RID: 1070
	public static GameObject[] particles;

	// Token: 0x0400042F RID: 1071
	public static GameObject LoadingScreen;

	// Token: 0x04000430 RID: 1072
	public static GameObject Coin;

	// Token: 0x04000431 RID: 1073
	public static GameObject Exp;

	// Token: 0x04000432 RID: 1074
	public static GameObject Aura;

	// Token: 0x04000433 RID: 1075
	public static GameObject Bomb;

	// Token: 0x04000434 RID: 1076
	public static GameObject BeamCircle;

	// Token: 0x04000435 RID: 1077
	public static AudioClip[] deathClips;

	// Token: 0x04000436 RID: 1078
	public static AudioClip[] hitClips;

	// Token: 0x04000437 RID: 1079
	public static AudioClip buttonClip;

	// Token: 0x04000438 RID: 1080
	public static GameObject[] queueObject;

	// Token: 0x04000439 RID: 1081
	public static AudioClip buildTurretSound;

	// Token: 0x0400043A RID: 1082
	public static AudioClip finalUpgrade;

	// Token: 0x0400043B RID: 1083
	public static AudioClip beam;

	// Token: 0x0400043C RID: 1084
	public static GameObject SpecialsComet;

	// Token: 0x0400043D RID: 1085
	public static GameObject SpecialsArrow;

	// Token: 0x0400043E RID: 1086
	public static GameObject SpecialsHeal;

	// Token: 0x0400043F RID: 1087
	public static GameObject SpecialsBomber;

	// Token: 0x04000440 RID: 1088
	public static GameObject SpecialsBeam;

	// Token: 0x04000441 RID: 1089
	public static GameObject Comet;

	// Token: 0x04000442 RID: 1090
	public static GameObject Arrow;

	// Token: 0x04000443 RID: 1091
	public static GameObject GoldDrop;

	// Token: 0x04000444 RID: 1092
	public static GameObject ExpDrop;
}
