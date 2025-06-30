using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test.Inputs
{
    [RequireComponent(typeof(Rigidbody))]

    public class PlayerMovement : MonoBehaviour
    {
        private float speed = 5f;
        private Rigidbody playerRB;

        private void Awake()
        {
            playerRB = GetComponent<Rigidbody>();
        }

        public void MoveCharacter(Vector3 direction)
        {
            playerRB.AddForce(direction * speed);
        }



    }

}