﻿using System;
using UnityEngine;

/// <summary> ゲーム内で使用する音をInspectorで設定するためのクラス </summary>
public class AudioHolder : MonoBehaviour
{
    #region Audio Controllers
    [Serializable]
    public class BGMController
    {
        [SerializeField]
        private BGMType _bgmType = default;
        [SerializeField]
        private AudioClip _bgmClip = default;

        public BGMType BGMType => _bgmType;
        public AudioClip BGMClip => _bgmClip;
    }

    [Serializable]
    public class SEController
    {
        [SerializeField]
        private SEType _seType = default;
        [SerializeField]
        private AudioClip _seClip = default;

        public SEType SEType => _seType;
        public AudioClip SEClip => _seClip;
    }
    #endregion

    [SerializeField]
    private BGMController[] _bgmClips = default;
    [SerializeField]
    private SEController[] _seClips = default;

    public BGMController[] BGMClips => _bgmClips;
    public SEController[] SEClips => _seClips;
}

public enum BGMType
{
    None,
    TitleBGM,
    InGameBGM,
    BossBGM,
    GameClear,
    GameOver
}

public enum SEType
{
    None,
    //System
    Select,
    Click,
    ChangeShot,
    //Player, Shot
    DefaultShot,
    LaserShot,
    Charge,
    ChargeBeam,
    ShotGun,
    Bomb,
    Missile,
    Reflect,
    MeleeMoving,
    Barrier,
    PlayerDamaged,
    PlayerCrashed,
    //Item
    AddPlusShot,
    EnemyAnnihilation,
    SpeedUp,
    Heal,
    //Enemy
    EnemyDamaged,
    EnemyCrashed,
    EnemyShot,
    EnemyJump,
    //Gimmick
    SpeedDown,
    WarpInitialized,
    WarpDestroyed,
    WarpEnterBullet,
    WarpExitBullet,
    Eruption,
}
