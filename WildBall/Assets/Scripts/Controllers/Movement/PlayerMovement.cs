using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(Animator))]

    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField, Range(0,10)] private float speed = 5f;
        private Rigidbody playerRB;
        private Animator animator;

        private void Awake()
        {
            playerRB = GetComponent<Rigidbody>();
            animator = GetComponent<Animator>();
        }

        public void MoveCharacter(float direction, float rotation)
        {
            playerRB.AddForce(new Vector3(direction * speed, 0));
            playerRB.transform.Rotate(0, rotation * speed * 1.5f, 0);
        }  

        public void PlayerJump()
        {
            
        }

#if UNITY_EDITOR
        [ContextMenu("Reset Values")]
        public void ResetValues() 
        {
            speed = 2; 
        }
#endif

    }

}