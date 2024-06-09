using UnityEngine;
using UnityEngine.UI;
using TMPro; // TextMeshPro ����� ���� ���ӽ����̽�

namespace YourNamespace
{
    public class AvatarCustomization : MonoBehaviour
    {
        public TMP_Dropdown heightDropdown; // TMP_Dropdown���� ����
        public TMP_Dropdown weightDropdown; // TMP_Dropdown���� ����
        public Button applyButton;

        public Transform avatar; // �ƹ�Ÿ�� Ʈ������

        private float baseHeight = 1.75f; // �⺻ Ű (����: meter)
        private float baseWeight = 70f; // �⺻ ������ (����: kg)
        private Vector3 initialAvatarLocalScale; // �ƹ�Ÿ�� �ʱ� ������

        void Start()
        {
            applyButton.onClick.AddListener(ApplyCustomization);

            // �ƹ�Ÿ�� �ʱ� ������ ����
            initialAvatarLocalScale = avatar.localScale;
        }

        void ApplyCustomization()
        {
            float height = float.Parse(heightDropdown.options[heightDropdown.value].text) / 100f; // cm to meter
            float weight = float.Parse(weightDropdown.options[weightDropdown.value].text);

            float heightScale = height / baseHeight;
            float weightScale = weight / baseWeight;

            // �ƹ�Ÿ�� ��ü ������ ����
            avatar.localScale = new Vector3(
                initialAvatarLocalScale.x * weightScale,
                initialAvatarLocalScale.y * heightScale,
                initialAvatarLocalScale.z * weightScale
            );

            // �ʿ��ϴٸ� �� ��ġ�� ũ�� ������Ʈ ���� �߰� ����
        }
    }
}
