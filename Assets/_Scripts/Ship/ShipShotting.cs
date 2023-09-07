using _Scripts.Bullets;
using _Scripts.Manager;
using UnityEngine;

namespace _Scripts.Ship
{
    public class ShipShotting : MonoBehaviour
    {
        [SerializeField] private Transform bulletSpwanPosition;
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private GameObject bulletsParent;
        [SerializeField] private float countdownBullet = .1f;
        private float timer;
        private bool isAttack;
        private void Update()
        {
            GetInput();
            ShottingHandle();
        }

        private void GetInput()
        {
            isAttack = InputManager.Instance.IsAttack;
        }

        private void ShottingHandle()
        {
            if (!isAttack) return;
            timer -= Time.deltaTime;
            if (timer > 0f) return;
            GameObject bullet = Instantiate(bulletPrefab,bulletSpwanPosition.position,Quaternion.identity,bulletsParent.transform);
            bullet.GetComponent<BulletFly>().SetDirection(transform.parent.right);
            timer = countdownBullet;
        }
    }
}
