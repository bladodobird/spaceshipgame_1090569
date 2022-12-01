using UnityEngine;

namespace YIZU
{
    /// <summary>
    /// 學習欄位
    /// </summary>

    public class LearnField : MonoBehaviour
    {
        // 欄位 Field : 儲存資料
        // 語法 :
        // 修飾詞 資料類型 欄位名稱 ;
        // 私人 : Private，僅在此類別內能存取
        private int lv;

        // 整數
        public int enemy = 5;

        // 浮點數
        public float speed = 3.5f;
        public float jump = 7.5f;

        public string namePlayer = "船";

        public bool isPass = false;
        public bool hasWeapon = true;

        [Header("血量")]
        public int hp = 999;
        [Tooltip("遊玩時間")]
        public float time = 10.5f;

        // 數值專用範圍
        [Range(1, 99)]
        public int level = 10;
        [Range(2f, 10.5f)]
        public float walkSpeed = 3.5f;
        // 不支援 int 跟 float 以外的資料
        [Range(1, 100)]
        public bool isOpen;

        // 序列化欄位
        //[SerializeField]
        //private int countBoomb = 7;
    }
}