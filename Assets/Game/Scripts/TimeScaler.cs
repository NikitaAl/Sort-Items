using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


namespace SortItems
{
    public class TimeScaler : MonoBehaviour
    {
        [SerializeField] private GameObject LoseScreen;
        [SerializeField] private TMP_Text _timerText;
        public TimeWork timeWork;
        public float countdown;
        float timer = 0f;
        public CharacterAnimationPlayer _character;
        [SerializeField] private GameObject _getters;

        public enum TimeWork
        {
            None,
            Stopwatch,
            Timer
        }

        private void Start() 
        {
            if ((int)timeWork == 2)
                timer = countdown;
        }

        private void Update() 
        {
            if ((int)timeWork == 1)
            {
                timer += Time.deltaTime;
                _timerText.text = timer.ToString("F2").Replace(",", ":");
            }
            else if ((int)timeWork == 2)
            {
                timer -= Time.deltaTime;
                _timerText.text = timer.ToString("F2").Replace(",", ":");
                if (timer <= 0)
                    Lose();
            }
            else 
                _timerText.gameObject.SetActive(false);
        }

        public void Lose()
        {
            LoseScreen.SetActive(true);
            _character.PlaySadidle();
            _getters.SetActive(false);
        }

        public void ReloadLevl()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void MenuLvl()
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
