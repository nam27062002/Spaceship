using _Scripts.Singleton;
using UnityEngine;

namespace _Scripts.Manager
{
    public class InputManager : Singleton<InputManager>
    {
        private Vector3 targetPosition;
        private bool isAttack;
        public Vector3 TargetPosition => targetPosition;
        public bool IsAttack => isAttack;
        private void Update()
        {
            GetInput();
        }

        private void GetInput()
        {
            if (Camera.main != null) targetPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
            isAttack = Input.GetMouseButton(0);
        }
    }
}
