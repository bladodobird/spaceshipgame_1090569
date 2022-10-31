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
    }
}