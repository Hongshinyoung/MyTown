using System;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatHandler:MonoBehaviour
{
    [SerializeField] private CharacterStats baseStats; //기본스텟
    public CharacterStats CurrentStats { get; private set; } //바뀔수도 있는 스텟
    public List<CharacterStats> statModifiers = new List<CharacterStats>();

    private void Awake()
    {
        UpdateCharacterStat();
    }

    private void UpdateCharacterStat()
    {
        AttackSO attackSO = null; //초기화느낌
        if (baseStats.attackSO != null) //인스펙터에서 넣어주면 있을것
        {
            attackSO = Instantiate(baseStats.attackSO);
        }

        CurrentStats = new CharacterStats { attackSO = attackSO };
        CurrentStats.statChangeType = baseStats.statChangeType;
        CurrentStats.maxHealth = baseStats.maxHealth;
        CurrentStats.speed = baseStats.speed;
    }
}
