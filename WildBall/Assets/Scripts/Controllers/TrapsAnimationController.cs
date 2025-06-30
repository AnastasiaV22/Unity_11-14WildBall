using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapsAnimationController : MonoBehaviour
{
    Animator animator;
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void RandomAnimationChanger()
    {
        int next = Random.Range(0, 3);
        Debug.Log(next);
        animator.SetInteger("NextState", next);
    }

}
