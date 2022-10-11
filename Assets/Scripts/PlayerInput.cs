using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))]

    public class PlayerInput : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float speed = 2.0f;
        private Rigidbody playerRigidbody;
        private Vector3 movement;

        private void Awake()
        {
            playerRigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            float horizontal = Input.GetAxis(GlobalStringVars.HORIZONTAL_AXIS);
            float Vertical = Input.GetAxis(GlobalStringVars.VERTICAL_AXIS);

            movement = new Vector3(-horizontal, 0, -Vertical);
        }

        private void FixedUpdate()
        {
            MoveCharacter();
        }

        private void MoveCharacter()
        {
            playerRigidbody.AddForce(movement);
        }

        #if UNITY_EDITOR
            [ContextMenu("Reset values")]
            public void ResetValues()
            {
                speed = 2;
            }
        #endif
    }
}