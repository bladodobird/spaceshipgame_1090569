using System;
using UnityEngine;

namespace YIZU
{
    /// <summary>
    /// 傷害系統
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("會造成傷害的目標")]
        private string nameTarget;
        [SerializeField, Header("爆炸預設物")]
        private GameObject prefabExplosion;
        [Header("受傷與爆炸音效")]
        [SerializeField]
        private AudioClip soundHit;
        [SerializeField]
        private AudioClip soundExplosion;

        // 碰撞離開事件 一次
        private void OnCollisionEnter2D(Collision2D collision)
        {
            // print("碰撞 : " + collision.gameObject);

            // 如果 碰到物件名稱 包含 敵機 就爆炸
            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);

                SoundManager.instance.PlaySound(soundHit, new Vector2(0.7f, 0.9f));
                SoundManager.instance.PlaySound(soundExplosion, new Vector2(1.2f, 1.5f));

                // 刪除此物件
                Destroy(gameObject);
            }
                
        }
    }
}