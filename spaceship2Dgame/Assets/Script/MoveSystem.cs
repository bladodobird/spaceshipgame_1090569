using UnityEngine;

namespace YIZU
{
    /// <summary>
    /// 移動系統
    /// </summary>
    public class MoveSystem : MonoBehaviour
    {
        [SerializeField, Header("移動速度"), Range(-10, 0)]
        private float speed = -3.5f;

        private void Update()
        {
            //Translate(x, y, z) 位移
            //Time.deltaTime 每幀數花費時間
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
    }
}


