using UnityEngine;

namespace YourNamespace
{
    public class PantsScaler : MonoBehaviour
    {
        public Transform waistTransform; // �㸮 �κ�
        public Transform hipTransform;   // ������ �κ�
        public float waistScaleFactor = 1.1f; // �㸮 ������ ����
        public float hipScaleFactor = 1.1f;   // ������ ������ ����

        void Start()
        {
            // �㸮 �κ� ������ ����
            if (waistTransform != null)
            {
                waistTransform.localScale *= waistScaleFactor;
            }

            // ������ �κ� ������ ����
            if (hipTransform != null)
            {
                hipTransform.localScale *= hipScaleFactor;
            }
        }
    }
}
