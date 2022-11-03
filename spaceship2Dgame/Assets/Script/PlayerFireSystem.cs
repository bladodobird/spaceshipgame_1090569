using UnityEngine;

namespace YIZU
{
    /// <summary>
    /// 玩家發射
    /// </summary>
    public class PlayerFireSystem : FireSystem
    {
        // 偵測玩家輸入行為 : 鍵盤 滑鼠 觸控 搖桿
        private void Update()
        {
            // 如果 玩家 按下空白建 生成 子彈
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }
        }

    }
}
