using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(Animator))]

    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float speed = 1f;
        [SerializeField] private float turnSpeed = 1f;
        [SerializeField] private float maxSpeed = 50f;

        private Rigidbody playerRB;
        private Animator animator;

        private Vector3 movmentDirection;
        private float currentPlayerRotation;

        private void Awake()
        {
            playerRB = GetComponent<Rigidbody>();
            animator = GetComponent<Animator>();
            
            playerRB.maxAngularVelocity = maxSpeed;
        }

        // -1 назад, 1 вперед
        public void MoveCharacter(float direction)
        {

            if (direction != 0)
            {
                playerRB.AddForce(transform.forward * direction * speed, ForceMode.Force);  
            
            }
        }

        public void RotateCharacter(float rotation)
        {
            if (rotation != 0)
            {

                Quaternion deltaRotation = Quaternion.Euler(0, rotation * turnSpeed * Time.fixedDeltaTime, 0);
                playerRB.MoveRotation(playerRB.rotation * deltaRotation);

            }
            else
            {
            }

        }

        public void PlayerJump()
        {
            
        }


#if UNITY_EDITOR
        [ContextMenu("Reset Values")]
        public void ResetValues() 
        {
            speed = 100f; 
        }
#endif

    }

}