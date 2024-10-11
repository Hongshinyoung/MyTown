using System;
using UnityEngine;

public class MyTownAnimationController: AnimationController
{
    private static readonly int isWalk = Animator.StringToHash("isWalk");
    private static readonly int isHit = Animator.StringToHash("isHit");
    private static readonly int doAttack = Animator.StringToHash("doAttack");

    private readonly float magitudeThreshold = 0.5f;


    protected override void Awake()
    {
        base.Awake(); //애니랑,컨트롤러
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
        controller.OnAttackEvent += Attack;
    }

    private void Attack()
    {
        animator.SetBool(doAttack, true);
    }

    private void Move(Vector2 vector)
    {
        animator.SetBool(isWalk, vector.magnitude > magitudeThreshold);
    }




}