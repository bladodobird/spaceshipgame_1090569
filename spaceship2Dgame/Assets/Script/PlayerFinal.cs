using UnityEngine;

namespace YIZU
{
    /// <summary>
    /// ���a���ѩιL��
    /// </summary>
    public class PlayerFinal : MonoBehaviour
    {
        // �Q�R���ɰ���@��
        private void OnDestroy()
        {
            // ����
            FinalManager.instance.GameOver("�A�z�F");
        }

        // �I��Ŀ� Is Trigger ����ɷ|����@��
        private void OnTriggerEnter2D(Collider2D collision)
        {
            // �L��
            FinalManager.instance.GameOver("�AĹ�F");
        }
    }
}