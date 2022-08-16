using UnityEngine;

namespace SortItems
{
    public class LevelSwap : MonoBehaviour
    {
        public GameObject currentScene;
        public GameObject scenePrefab;


        
        void Start()
        {
            Destroy(currentScene);
            currentScene = Instantiate(scenePrefab);
        }

        

    }
}
