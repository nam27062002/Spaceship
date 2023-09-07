using System;
using _Scripts.Manager;
using UnityEngine;

namespace _Scripts.Ship
{
    public class ShipMovement : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 1f;
        private Vector3 targetPosition;
        
        private void Update()
        {
            GetInput();
            LookAtHandle();
            MovementHandle();
        }

        private void GetInput()
        {
            targetPosition = InputManager.Instance.TargetPosition;
            targetPosition.z = 0;
        }

        private void MovementHandle()
        {
            float step = moveSpeed * Time.deltaTime;
            transform.parent.position = Vector3.MoveTowards(transform.parent.position, targetPosition, step);
        }


        private void LookAtHandle()
        {
            Vector3 direction = targetPosition - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.parent.eulerAngles = new Vector3(0, 0, angle);
        }
    }   
}
