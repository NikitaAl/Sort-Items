using UnityEngine;
using UnityEngine.UI;
using TMPro;


namespace SortItems
{
    public class SoundEffector : MonoBehaviour
    {
        // [SerializeField] private Slider musicSlider, soundSlider;
        // [SerializeField] private TMP_Text musicText, soundText;
        [SerializeField] private float musicVolume = 1f;
        [SerializeField] private AudioSource audioSrc;

        void Start()
        {
        //     if (!PlayerPrefs.HasKey("MusicVolume"))
        //     {
        //         PlayerPrefs.SetInt("MusicVolume", 2);
        //     }
        //     if (!PlayerPrefs.HasKey("SoundVolume"))
        //     {
        //         PlayerPrefs.SetInt("SoundVolume", 2);
        //     }

        // musicSlider.value = PlayerPrefs.GetInt("MusicVolume");
        // soundSlider.value = PlayerPrefs.GetInt("SoundVolume");

        audioSrc = GetComponent<AudioSource>();

        }

        void Update()
        {
            // PlayerPrefs.SetInt("MusicVolume", (int)musicSlider.value);
            // PlayerPrefs.SetInt("SoundVolume", (int)soundSlider.value);
            // musicText.text = musicSlider.value.ToString();
            // soundText.text = soundSlider.value.ToString();

            audioSrc.volume = musicVolume;
        }

        public void SetVolume(float vol)
        {
            musicVolume = vol;
        }
    }
}
