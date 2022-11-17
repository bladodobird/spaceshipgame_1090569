using UnityEngine;

namespace YIZU
{
    /// <summary>
    /// �R������
    /// </summary>
    public class DestroyObject : MonoBehaviour
    {
        [SerializeField, Header("�R���ɶ�"), Range(0, 3)]
        private float destroyTime = 0.5f;

        private void Awake()
        {
            // gmaeObject �}�����C������
            // �R������ �ɶ�
            Destroy(gameObject, destroyTime);
        }

        // �i���ƥ� : �� Renderer �X�{�b Scene �� Game �ɰ���@��
        private void OnBecameVisible()
        {
            
        }

        // ���i���ƥ� �P�W�������ɰ���@��
        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }
}