using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Text;
using TMPro;

namespace SortItems
{
    public class Main : MonoBehaviour
    {
        [SerializeField] private Button[] lvls;

        private void Start() 
        {
            if (PlayerPrefs.HasKey("Lvl"))
                for (int i = 0; i < lvls.Length; i++)
                {
                    if (i <= PlayerPrefs.GetInt("Lvl"))
                        lvls[i].interactable = true;
                    else
                        lvls[i].interactable = false;
                }
            
        }
 
        public void DelKeys()
        {
            PlayerPrefs.DeleteAll();
        }

    }
}
