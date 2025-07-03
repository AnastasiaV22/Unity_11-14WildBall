using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    public class InputController : MonoBehaviour
    {
        [SerializeField] private PlayerMovement playerMovement;
        
        private float move;
        private float rotate;

        private void Update()
        {
            rotate = Input.GetAxis(GlobalStringVars.HORIZONTAL_AXIS);
            move = Input.GetAxis(GlobalStringVars.VERTICAL_AXIS);

            if (Input.GetButtonDown(GlobalStringVars.JUMP_BUTTON))
                playerMovement.PlayerJump();

        }

        void FixedUpdate()
        {
            playerMovement.MoveCharacter(move, -rotate);

        }
    }

}
