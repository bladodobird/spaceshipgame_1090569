using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace YIZU
{
    /// <summary>
    /// �����޲z��
    /// </summary>
    public class FinalManager : MonoBehaviour
    {
        /// <summary>
        /// �����e��
        /// </summary>>
        private CanvasGroup groupFinal;
        /// <summary>
        /// �������D
        /// </summary>
        private TextMeshProUGUI textTitle;
        /// <summary>
        /// ���s�C��
        /// </summary>>
        private Button btnReplay;

        private void Awake()
        {
            groupFinal = GameObject.Find("�����e��").GetComponent<CanvasGroup>();
            textTitle = GameObject.Find("�������D").GetComponent<TextMeshProUGUI>();
            btnReplay = GameObject.Find("���s�C��").GetComponent<Button>();
        }


    }
}