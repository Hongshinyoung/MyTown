using UnityEngine;

public enum StatChangeType
{
    Add,
    Multiple,
    Override
}


[System.Serializable]
public class CharacterStats
{
    public StatChangeType statChangeType;
    [Range(1, 100)] public int maxHealth;
    [Range(1, 100)] public float speed;
    public AttackSO attackSO;
}
