using System;
using UnityEngine;

namespace _Scripts.Bullets
{
    public class BulletFly : MonoBehaviour
    {
        [SerializeField] private float maxDistanceDestroy = 100f;
        [SerializeField] private float moveSpeed = 100f;
        private Vector3 targetPosition;
        private Vector3 direction;
        void Update()
        {
            BulletHandle();
        }
        public void SetDirection(Vector3 direction)
        {
            this.direction = direction;
        }

        private void BulletHandle()
        {
            transform.position += direction.normalized * moveSpeed * Time.deltaTime;
        }
    }
}