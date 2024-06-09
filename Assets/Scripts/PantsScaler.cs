using UnityEngine;

namespace YourNamespace
{
    public class PantsScaler : MonoBehaviour
    {
        public Transform waistTransform; // 허리 부분
        public Transform hipTransform;   // 엉덩이 부분
        public float waistScaleFactor = 1.1f; // 허리 스케일 팩터
        public float hipScaleFactor = 1.1f;   // 엉덩이 스케일 팩터

        void Start()
        {
            // 허리 부분 스케일 조정
            if (waistTransform != null)
            {
                waistTransform.localScale *= waistScaleFactor;
            }

            // 엉덩이 부분 스케일 조정
            if (hipTransform != null)
            {
                hipTransform.localScale *= hipScaleFactor;
            }
        }
    }
}
