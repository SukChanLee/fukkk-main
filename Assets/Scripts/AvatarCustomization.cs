using UnityEngine;
using UnityEngine.UI;
using TMPro; // TextMeshPro 사용을 위한 네임스페이스

namespace YourNamespace
{
    public class AvatarCustomization : MonoBehaviour
    {
        public TMP_Dropdown heightDropdown; // TMP_Dropdown으로 변경
        public TMP_Dropdown weightDropdown; // TMP_Dropdown으로 변경
        public Button applyButton;

        public Transform avatar; // 아바타의 트랜스폼

        private float baseHeight = 1.75f; // 기본 키 (단위: meter)
        private float baseWeight = 70f; // 기본 몸무게 (단위: kg)
        private Vector3 initialAvatarLocalScale; // 아바타의 초기 스케일

        void Start()
        {
            applyButton.onClick.AddListener(ApplyCustomization);

            // 아바타의 초기 스케일 저장
            initialAvatarLocalScale = avatar.localScale;
        }

        void ApplyCustomization()
        {
            float height = float.Parse(heightDropdown.options[heightDropdown.value].text) / 100f; // cm to meter
            float weight = float.Parse(weightDropdown.options[weightDropdown.value].text);

            float heightScale = height / baseHeight;
            float weightScale = weight / baseWeight;

            // 아바타의 전체 스케일 조절
            avatar.localScale = new Vector3(
                initialAvatarLocalScale.x * weightScale,
                initialAvatarLocalScale.y * heightScale,
                initialAvatarLocalScale.z * weightScale
            );

            // 필요하다면 얼굴 위치와 크기 업데이트 로직 추가 가능
        }
    }
}
