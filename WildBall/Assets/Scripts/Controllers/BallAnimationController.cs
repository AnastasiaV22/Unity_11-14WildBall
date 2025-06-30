using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAnimationController : StateMachineBehaviour
{

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        int next = Random.Range(0, 3);
        Debug.Log(next);
        animator.SetInteger("NextState", next);   
    }


}
