using UnityEngine;

namespace SortItems
{
    public class CkickResetPool : MonoBehaviour
    {
        [SerializeField] private ClickPool _clickPool;

        private void OnDisable() 
        {
            _clickPool.ResetPool();    
        }
    }
}
