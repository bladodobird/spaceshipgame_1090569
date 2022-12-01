using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace YIZU
{
    /// <summary>
    /// 選單管理器
    /// </summary>
    
    public class MenuManager : MonoBehaviour
    {
        /// <summery>
        /// 開始遊戲
        /// </summery>
        private Button btnPlay;

        private void Awake()
        {
            btnPlay = GameObject.Find("開始遊戲").GetComponent<Button>();
            btnPlay.onClick.AddListener(StartGame);
        }

        /// <summery>
        /// 開始遊戲
        /// </summery>
        private void StartGame()
        {
            SceneManager.LoadScene(1);
        }
    }
}