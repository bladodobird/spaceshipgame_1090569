using UnityEngine;

namespace YIZU
{

    public class FristScript : MonoBehaviour
    {
        #region 
        //開始事件 : 在 Awake 後執行一次
        private void Awake()
        {
            print("Hi");
        }

        //開始事件 : 在 Awake 後執行一次
        private void Start()
        {
            print("<color=yellow>這是開始事件</color>");
        }

        //更新事件 : 在 Start 後執行，執行次數約 60 FPS
        private void Update()
        {
            print("<color=red>更新事件!</color>");
        }
        #endregion
    }
}