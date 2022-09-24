using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SortItems
{
    public class Sound : MonoBehaviour
    {

        [SerializeField] private AudioSource musicSource, soundSource;
        [SerializeField] private SoundEffector _soundEffector;


        private void Start()
        {
            musicSource.volume = (float)PlayerPrefs.GetInt("MusicVolume") / 9;
            soundSource.volume = (float)PlayerPrefs.GetInt("SoundVolume") / 9;        
        }
    }
}
