using UnityEngine;

public class AnimationController: MonoBehaviour
{
    protected Animator animator;
    protected MyTownController controller;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<MyTownController>();
    }
}
