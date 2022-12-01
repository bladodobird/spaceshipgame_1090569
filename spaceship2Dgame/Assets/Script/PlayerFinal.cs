using UnityEngine;

namespace YIZU
{
    /// <summary>
    /// 玩家失敗或過關
    /// </summary>
    public class PlayerFinal : MonoBehaviour
    {
        // 被刪除時執行一次
        private void OnDestroy()
        {
            // 失敗
            FinalManager.instance.GameOver("你爆了");
        }

        // 碰到勾選 Is Trigger 物件時會執行一次
        private void OnTriggerEnter2D(Collider2D collision)
        {
            // 過關
            FinalManager.instance.GameOver("你贏了");
        }
    }
}