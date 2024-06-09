using UnityEngine;
using UnityEngine.UI;

namespace YourNamespace
{
    public class WardrobeManager : MonoBehaviour
    {
        public Button pantsButton;
        public GameObject avatar;

        // 바지 Prefab을 참조
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

            // 바지 위치 조정
            Vector3 pantsPositionAdjustment = new Vector3(0.02f, 0, 0.1f); // Z축을 기준으로 앞으로 0.1 단위 이동
            currentClothing.transform.localPosition += pantsPositionAdjustment;

            // 바지 크기 조정
            Vector3 pantsScaleAdjustment = new Vector3(1.1f, 1.1f, 1.1f); // 크기를 1.1배로 조정
            currentClothing.transform.localScale = Vector3.Scale(currentClothing.transform.localScale, pantsScaleAdjustment);

            // PantsScaler 스크립트 추가 및 설정
            PantsScaler pantsScaler = currentClothing.AddComponent<PantsScaler>();
            pantsScaler.waistTransform = currentClothing.transform.Find("Waist"); // 허리 부분 Transform 설정
            pantsScaler.hipTransform = currentClothing.transform.Find("Hip");     // 엉덩이 부분 Transform 설정
            pantsScaler.waistScaleFactor = 1.1f; // 허리 스케일 팩터 설정
            pantsScaler.hipScaleFactor = 1.2f;   // 엉덩이 스케일 팩터 설정

            // 추가적으로 옷의 위치나 크기 조정을 여기서 할 수 있습니다.
        }
    }
}
