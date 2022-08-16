using UnityEngine;
using UnityEngine.Events;

namespace SortItems
{
    public class ScoreHandler : MonoBehaviour
    {
        [SerializeField] private GetterParemeters[] _getters;

        // public GameObject NewPref;
        // public GameObject OldPref;
        public GameObject currentScene;
        public GameObject scenePrefab;

        public UnityEvent onFull;

        private void Start() 
        {
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
                // Instantiate (NewPref, OldPref.transform.position, OldPref.transform.rotation); 
                //     Destroy(OldPref); 
                Destroy(currentScene);
                ScenChenger();
            }
        }

        private void ScenChenger()
        {
            currentScene = Instantiate(scenePrefab);
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
