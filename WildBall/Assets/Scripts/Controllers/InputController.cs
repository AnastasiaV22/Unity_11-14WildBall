using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test.Inputs
{
    public class InputController : MonoBehaviour
    {
        private Vector3 direction;
        [SerializeField] private PlayerMovement playerMovement;
        

        private void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            direction = new Vector3(vertical, 0, -horizontal).normalized;
        }

        void FixedUpdate()
        {
            playerMovement.MoveCharacter(direction);

        }
    }

}
