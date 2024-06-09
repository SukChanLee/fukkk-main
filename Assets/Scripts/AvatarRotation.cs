using UnityEngine;

namespace YourNamespace
{
    public class AvatarRotation : MonoBehaviour
    {
        public float rotationSpeed = 100f; // 회전 속도

        void Update()
        {
            // 좌우 화살표 키 입력 받아서 아바타 회전
            float horizontalInput = Input.GetAxis("Horizontal");

            if (horizontalInput != 0)
            {
                float rotationAmount = horizontalInput * rotationSpeed * Time.deltaTime;
                transform.Rotate(Vector3.up, rotationAmount);
            }
        }
    }
}
