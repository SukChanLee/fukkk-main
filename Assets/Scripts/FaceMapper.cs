using UnityEngine;

namespace YourNamespace
{
    public class FaceMapper : MonoBehaviour
    {
        public Transform avatarHead;
        public GameObject faceModel;

        private Vector3 originalPositionOffset = new Vector3(-0.018f, 1.672f, -0.074f);
        private Quaternion originalRotationOffset = Quaternion.Euler(0, 180, 0);

        void Start()
        {
            MapFaceToAvatar();
        }

        public void MapFaceToAvatar()
        {
            avatarHead.gameObject.SetActive(false);

            faceModel.transform.position = avatarHead.position + originalPositionOffset;
            faceModel.transform.rotation = avatarHead.rotation * originalRotationOffset;
            faceModel.transform.localScale = avatarHead.localScale;
        }

        public void UpdateFacePositionAndScale(float heightScale, float weightScale)
        {
            faceModel.transform.position = avatarHead.position + originalPositionOffset * heightScale;
            faceModel.transform.localScale = new Vector3(weightScale, weightScale, weightScale);
        }
    }
}
