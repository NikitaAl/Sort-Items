using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace SortItems
{
    public class ScoreHandler : MonoBehaviour
    {
        [SerializeField] private GetterParemeters[] _getters;
        public CharacterAnimationPlayer _character;

        [SerializeField] private TMP_Text _text;
        [SerializeField] private ItemTypeColor _typeColor;

        [SerializeField] private GameObject _gette;

        public GameObject WinScreen;
        public GameObject MenuScreen;

        public UnityEvent onFull;

        [SerializeField] private GameObject _stars;

        private void Start() 
        {
            MenuScreen.SetActive(true);
            if (_getters == null)
            {
                Debug.LogError("Getters is null");
                return;
            }    

            foreach (var getter in _getters)
            {
                getter.getter.SetCount(getter.targetCount);
                getter.getter.onCountChanged.AddListener(OnCountChanged);
            }   

            StringBuilder builder = new StringBuilder("Collect ");
            builder.Append("<color=#")
                    .Append(ColorUtility.ToHtmlStringRGB(_typeColor.colors[(int)_getters[0].getter.Type].color))
                    .Append(">")
                    .Append(_getters[0].getter.Type.ToString().ToLower());
            if (_getters.Length > 1)
            {
                for (int i = 1; i < _getters.Length; i++)
                {
                    builder.Append("<color=\"white\">")
                            .Append(" and ")
                            .Append("<color=#")
                            .Append(ColorUtility.ToHtmlStringRGB(_typeColor.colors[(int)_getters[i].getter.Type].color))
                            .Append(">")
                            .Append(_getters[i].getter.Type.ToString().ToLower());
                }
            }

            _text.text = builder.ToString();
        }

        private void OnDestroy() 
        {
            foreach (var getter in _getters)
            {
                getter.getter.onCountChanged.RemoveListener(OnCountChanged);
            }
        }

        private void OnCountChanged(Getter getter)
        {
            for (int idx = 0; idx < _getters.Length; idx++)
            {
                ref var item = ref  _getters[idx];

                if (item.getter != getter)
                    continue;

                item.count++;
            }

            bool full = true;

            foreach (GetterParemeters item in _getters)
            {
                if (item.count < item.targetCount)
                {
                    full = false;

                    break;
                }
            }

            if (full)
            {   
                Debug.Log("You win!");

                onFull.Invoke();
                _stars.SetActive(true);
                MenuScreen.SetActive(false);
                WinScreen.SetActive(true);
                _gette.SetActive(false);

                if (!PlayerPrefs.HasKey("Lvl") || PlayerPrefs.GetInt("Lvl") < SceneManager.GetActiveScene().buildIndex)
                    PlayerPrefs.SetInt("Lvl", SceneManager.GetActiveScene().buildIndex);

                _character.PlayRumbaDancing();
                    Debug.Log("Dancing");
                // Time.timeScale = 0f;      
            }
        }

    }


    [System.Serializable]
    public struct GetterParemeters
    {
        public Getter getter;

        public int targetCount;

        [HideInInspector]public int count;
    }
}
