using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

namespace SortItems
{
    public class SceneChanger : MonoBehaviour
    {

        public void Nextlevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        public void OpenScene(int index)
        {
            SceneManager.LoadScene(index);
        }
    
        public void ReloadScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        private void Update() 
        {
            if ( Input.GetKeyUp(KeyCode.R))
            {
                ReloadScene();          
            }
        }

        // [SerializeField] private GameObject[] _levels;
        // private GameObject _currentLevel;
        // public GameObject _next;

        // private void Start() 
        // {
        //     var level = PlayerPrefs.GetInt("Level", 0);
        //     var idx = SceneManager.GetActiveScene().buildIndex;
        //     if (level != idx)
        //     {
        //         LoadLevel(level);
        //     } 
            
        // }
        // public void LoadLevel(int levelIdx)
        // {
        //     var idx = SceneManager.GetActiveScene().buildIndex;
        //     var sceneCount = SceneManager.sceneCountInBuildSettings;
        //     var nextLevel = (levelIdx) % sceneCount;
        //     SceneManager.LoadScene(nextLevel);
        // }

        // public void LoadNextLevel()
        // {
        //     var idx = SceneManager.GetActiveScene().buildIndex;
        //     var sceneCount = SceneManager.sceneCountInBuildSettings;
        //     var nextLevel = (idx + 1) % sceneCount;
        //     PlayerPrefs.SetInt("Level", nextLevel);
        //     SceneManager.LoadScene(nextLevel);

        // }
        // public void LoadLevel()
        // {
        //     if ( _currentLevel != null)
        //     {
        //         Destroy(_currentLevel);
        //         _next.SetActive(true);
        //         Time.timeScale = 0f;
        //     }

        //     var idx = SceneManager.GetActiveScene().buildIndex;
        //     var sceneCount = SceneManager.sceneCountInBuildSettings;
        //     var nextLevel = (idx) % sceneCount;

        //     _currentLevel = Instantiate(_levels[nextLevel]);
        // }

        // public void NextLevel()
        // {
        //     var idx = SceneManager.GetActiveScene().buildIndex;
        //     var sceneCount = SceneManager.sceneCountInBuildSettings;
        //     var nextLevel = (idx + 1) % sceneCount;
        //     PlayerPrefs.SetInt("Level", nextLevel);

        //     LoadLevel();
        // }




    }
}
