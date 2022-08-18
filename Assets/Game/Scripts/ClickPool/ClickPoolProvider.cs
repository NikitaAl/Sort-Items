using UnityEngine;

namespace SortItems
{
    public class ClickPoolProvider : MonoBehaviour
    {
        [SerializeField] private ClickPool _clickPool;
        
        public ClickPool ClickPool => _clickPool;


        private void Awake() 
        {
            ClickPool.InitializePool();
        }
    }
}
