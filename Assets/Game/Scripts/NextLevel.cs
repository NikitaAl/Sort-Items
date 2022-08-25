using UnityEngine;
using UnityEngine.SceneManagement;


namespace SortItems
{
    public class NextLevel : MonoBehaviour
    {
        // [SerializeField] private GameObject[] _levels;
        // private GameObject _currentLevel;
        
        // public GameObject _currentLevel;
        // public GameObject _nextlevel;
        // public GameObject currentScene;
        // public GameObject scenePrefab;

        public void LoadLevel()
        {

        }

        private void Start() 
        {
            // var level = PlayerPrefs.GetInt("Level", 0);
            // var idx = SceneManager.GetActiveScene().buildIndex;
            // if (level != idx)
            // {
            //     LoadLevel(level);
            // } 
            // _currentLevel = Instantiate(_levels);
            // LoadLevel();
            // _currentLevel = Instantiate(_nextlevel);
            // Destroy(_currentLevel);

                // if ( currentScene != null)
                //     Destroy(currentScene);

                // currentScene = Instantiate(scenePrefab);                           

        }

        // public void LoadLevel()
        // {
        //     if (_currentLevel != null)
        //         Destroy(_currentLevel);
        //     Debug.Log("Destroy" + _currentLevel);       
            
        //     var idx = SceneManager.GetActiveScene().buildIndex;
        //     var sceneCount = SceneManager.sceneCountInBuildSettings;
        //     var nextLevel = (idx + 0) % sceneCount;

        //     _currentLevel = Instantiate(_levels[nextLevel]);
        // }

        // public void RNextLevel()
        // {
        //     var idx = SceneManager.GetActiveScene().buildIndex;
        //     var sceneCount = SceneManager.sceneCountInBuildSettings;
        //     var nextLevel = (idx + 1) % sceneCount;
        //     PlayerPrefs.SetInt("Level", nextLevel);
        //     SceneManager.LoadScene(nextLevel);
        //     LoadLevel();

        // }
    }
}
