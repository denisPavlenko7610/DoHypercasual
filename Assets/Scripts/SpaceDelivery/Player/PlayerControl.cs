using System;
using UnityEngine;

namespace SpaceDelivery.Player
{
    public class PlayerControl : MonoBehaviour
    {
        [SerializeField] private Transform bike;
        [SerializeField] private Joystick joystick;
        [SerializeField] private Animator playerAnimator;
        private static readonly int TurnRight = Animator.StringToHash("TurnRight");
        private static readonly int TurnLeft = Animator.StringToHash("TurnLeft");
        private static readonly int IdleLeft = Animator.StringToHash("IdleLeft");
        private static readonly int IdleRight = Animator.StringToHash("IdleRight");
        private bool _isIdleLeft;
        private bool _isIdleRight;
        private bool _isCanIdle;

        private void OnValidate()
        {
            if (joystick == null)
            {
                joystick = FindObjectOfType<Joystick>();
            }
        }

        private void Update()
        {
            SetRotation();
            SetTurnAnimation();
        }

        private void SetTurnAnimation()
        {
            if (joystick.Horizontal > 0.1f)
            {
                playerAnimator.SetBool(TurnRight, true);
                playerAnimator.SetBool(TurnLeft, false);
                playerAnimator.SetBool(IdleRight, false);
                _isIdleRight = true;
                _isCanIdle = true;
            }
            else if (joystick.Horizontal < -0.1f)
            {
                playerAnimator.SetBool(TurnLeft, true);
                playerAnimator.SetBool(TurnRight, false);
                playerAnimator.SetBool(IdleLeft, false);
                _isIdleLeft = true;
                _isCanIdle = true;
            }
            else if (Mathf.Approximately(joystick.Horizontal,0))
            {
                if (_isIdleLeft && _isCanIdle)
                {
                    playerAnimator.SetBool(TurnLeft, false);
                    playerAnimator.SetBool(IdleLeft, true);
                    _isCanIdle = false;
                }
                else if (_isIdleRight && _isCanIdle)
                {
                    playerAnimator.SetBool(TurnRight, false);
                    playerAnimator.SetBool(IdleRight, true);
                    _isCanIdle = false;
                }

                _isIdleLeft = false;
                _isIdleRight = false;
            }
        }

        private void SetRotation()
        {
            transform.rotation = bike.rotation;
        }
    }
}