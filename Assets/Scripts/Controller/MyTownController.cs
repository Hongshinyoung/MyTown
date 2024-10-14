using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    public event Action OnAttackEvent;

    private float timeSinceLastAttack = float.MaxValue;

    protected bool isAttacking { get; set; }
    protected CharacterStatHandler characterStatHandler { get; private set; }
    protected virtual void Awake()
    {
        characterStatHandler = GetComponent<CharacterStatHandler>();
    }
    private void Update()
    {
        AttackDelay();
    }

    private void AttackDelay()
    {
        if(timeSinceLastAttack < characterStatHandler.CurrentStats.attackSO.delay)
        {
            timeSinceLastAttack += Time.deltaTime;
        }
        else if(timeSinceLastAttack > characterStatHandler.CurrentStats.attackSO.delay && isAttacking)
        {
            timeSinceLastAttack = 0f;
            CallAttackEvent();
        }
    }

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

    public void CallAttackEvent()
    {
        OnAttackEvent?.Invoke();
    }

}
