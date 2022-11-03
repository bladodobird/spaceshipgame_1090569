using UnityEngine;

namespace YIZU
{

    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("會造成傷害的目標")]
        private string nameTarget;

        // 碰撞開始事件 一次
        private void OnCollisionEnter2D(collision2D collision)
        {
            print("碰撞 : " + collision.gameObject);
        }

        // 碰撞離開事件 一次
        private void OnCollisionExit2D(collision2D collision)
        {

        }
        
        // 碰撞持續事件
        private void OnCollisionStay2D(collision2D collision)
        {

        }
    }
}