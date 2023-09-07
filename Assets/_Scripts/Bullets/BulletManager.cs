using System;
using _Scripts.Manager;
using UnityEngine;

namespace _Scripts.Bullets
{
    public class BulletManager : MonoBehaviour
    {
        [SerializeField] private float maxDistanceBulletDestroy = 100f;

        private void Start()
        {
            InvokeRepeating("DestroyBullets",0f,1f);
        }

        private void DestroyBullets()
        {
            Vector3 targetPosition = InputManager.Instance.TargetPosition;
            foreach (Transform child in transform)
            {
                if (Vector3.Distance(child.position, targetPosition) > maxDistanceBulletDestroy)
                {
                    Destroy(child.gameObject);
                }
            }
        }
    }
}
