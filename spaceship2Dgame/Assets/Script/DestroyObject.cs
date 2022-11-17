using UnityEngine;

namespace YIZU
{
    /// <summary>
    /// 刪除物件
    /// </summary>
    public class DestroyObject : MonoBehaviour
    {
        [SerializeField, Header("刪除時間"), Range(0, 3)]
        private float destroyTime = 0.5f;

        private void Awake()
        {
            // gmaeObject 腳本的遊戲物件
            // 刪除物件 時間
            Destroy(gameObject, destroyTime);
        }

        // 可見事件 : 當 Renderer 出現在 Scene 或 Game 時執行一次
        private void OnBecameVisible()
        {
            
        }

        // 不可見事件 同上但消失時執行一次
        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }
}