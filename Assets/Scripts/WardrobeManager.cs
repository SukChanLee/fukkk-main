using UnityEngine;
using UnityEngine.UI;

namespace YourNamespace
{
    public class WardrobeManager : MonoBehaviour
    {
        public Button pantsButton;
        public GameObject avatar;

        // ���� Prefab�� ����
        public GameObject pantsPrefab;

        private GameObject currentPants;

        void Start()
        {
            pantsButton.onClick.AddListener(() => ChangeClothes(pantsPrefab, ref currentPants));
        }

        void ChangeClothes(GameObject clothingPrefab, ref GameObject currentClothing)
        {
            if (currentClothing != null)
            {
                Destroy(currentClothing);
            }

            currentClothing = Instantiate(clothingPrefab, avatar.transform);

            // ���� ��ġ ����
            Vector3 pantsPositionAdjustment = new Vector3(0.02f, 0, 0.1f); // Z���� �������� ������ 0.1 ���� �̵�
            currentClothing.transform.localPosition += pantsPositionAdjustment;

            // ���� ũ�� ����
            Vector3 pantsScaleAdjustment = new Vector3(1.1f, 1.1f, 1.1f); // ũ�⸦ 1.1��� ����
            currentClothing.transform.localScale = Vector3.Scale(currentClothing.transform.localScale, pantsScaleAdjustment);

            // PantsScaler ��ũ��Ʈ �߰� �� ����
            PantsScaler pantsScaler = currentClothing.AddComponent<PantsScaler>();
            pantsScaler.waistTransform = currentClothing.transform.Find("Waist"); // �㸮 �κ� Transform ����
            pantsScaler.hipTransform = currentClothing.transform.Find("Hip");     // ������ �κ� Transform ����
            pantsScaler.waistScaleFactor = 1.1f; // �㸮 ������ ���� ����
            pantsScaler.hipScaleFactor = 1.2f;   // ������ ������ ���� ����

            // �߰������� ���� ��ġ�� ũ�� ������ ���⼭ �� �� �ֽ��ϴ�.
        }
    }
}
