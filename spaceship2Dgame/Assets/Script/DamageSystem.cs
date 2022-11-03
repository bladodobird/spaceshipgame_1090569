using UnityEngine;

namespace YIZU
{

    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("�|�y���ˮ`���ؼ�")]
        private string nameTarget;
        [SerializeField, Header("�z���w�m��")]
        private GameObject prefabExplosion;

        // �I���}�l�ƥ� �@��
        private void OnCollisionEnter2D(collision2D collision)
        {
            //print("�I�� : " + collision.gameObject);

            // �p�G �I�쪫��W�� �]�t �ľ� �N�z��
            if (collision.gameObject.name.Contain(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);

                // Destroy
                // gameObject
                Destroy(gameObject);
            }
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