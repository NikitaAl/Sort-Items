using UnityEngine;
using UnityEngine.UI;

namespace SortItems
{
    public class LevelProgressUI : MonoBehaviour
    {
        [SerializeField] private Image _uiFillImage;
        [SerializeField] private Text _uiSratText;



        public void StartLevelText (int level)
        {
            _uiSratText.text = level.ToString();
            
            _uiFillImage.fillAmount = 1;
        }
    }
}
