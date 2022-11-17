using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace YIZU
{
    /// <summary>
    /// ���޲z��
    /// </summary>
    public class MenuManager : MonoBehaviour
    {
        /// <summery>
        /// �}�l�C��
        /// </summery>
        private Button btnPlay;

        private void Awake()
        {
            btnPlay = GameObject.Find("�}�l�C��").GetComponent<Button>();
            btnPlay.onClick.AddListener(StartGame);
        }

        /// <summery>
        /// �}�l�C��
        /// </summery>
        private void StartGame()
        {
            SceneManager.LoadScene("�C��������");
        }
    }
}