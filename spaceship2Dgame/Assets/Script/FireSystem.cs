using UnityEngine;

namespace YIZU
{ 
    /// <summary>
    /// 發射系統基底類別
    /// 生成子彈
    /// </summary>

    public class FireSystem : MonoBehaviour
    {
        [SerializeField, Header("子彈預置物")]
        private GameObject prefabullet;
        [SerializeField, Header("子彈生成點")]
        private Transform pointSpawn;
        [SerializeField, Header("發射音效")]
        private AudioClip soundFire;

        // 自訂方法
        // 生成子彈
        // protected 保護級別允許子類別存取
        protected void SpawnBullet()
        {
            // 實例物件座標角度
            // 生成 子彈預置物
            Instantiate(prefabullet, pointSpawn.position, pointSpawn.rotation);

            // 取範圍
            SoundManager.instance.PlaySound(soundFire, new Vector2(0.7f, 1.2f));
        }
    }
}