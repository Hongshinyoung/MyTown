using UnityEngine;

public class MyTownAttack:MonoBehaviour
{
    private MyTownController controller;


    private void Awake()
    {
        controller = GetComponent<MyTownController>();
    }

    private void Start()
    {
        controller.OnAttackEvent += Attack;
    }

    private void Attack()
    {

    }
}
