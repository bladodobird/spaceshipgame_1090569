using UnityEngine;

namespace YIZU
{

    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("�|�y���ˮ`���ؼ�")]
        private string nameTarget;

        // �I���}�l�ƥ� �@��
        private void OnCollisionEnter2D(collision2D collision)
        {
            print("�I�� : " + collision.gameObject);
        }

        // �I�����}�ƥ� �@��
        private void OnCollisionExit2D(collision2D collision)
        {

        }
        
        // �I������ƥ�
        private void OnCollisionStay2D(collision2D collision)
        {

        }
    }
}