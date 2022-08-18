using System.Collections.Generic;
using UnityEngine;

namespace SortItems
{
    [CreateAssetMenu(fileName = "ClickPool", menuName = "Game/ClickPool", order = 1)]

    public class ClickPool : ScriptableObject
    {
        [SerializeField] private int _size = 5;
        [SerializeField] private GameObject _clickPrefab;  

        private List<ClickPoolItem> _items; 
        private Queue<ClickPoolItem> _queue;   

                private bool _poolIsInitialized = false;

                public void InitializePool()
        {
            if (_poolIsInitialized)
            {
                return;
            }
            
            _items = new List<ClickPoolItem>(_size);
            _queue = new Queue<ClickPoolItem>();

            for (int i = 0; i < _size; i++)
            {
                CreateItem();
            }
            
            _poolIsInitialized = true;
        }
        
         public void ResetPool()
        {
            _items.ForEach(item => 
            {
                if (item != null && item.gameObject != null)
                {
                    Destroy(item);
                }
            });

            _items?.Clear();
            _queue?.Clear();

            _poolIsInitialized = false;
        }

        public ClickPoolItem GetFromPool()
        {
            if (_queue.Count == 0)
            {
                ExpanPool();
            }

            ClickPoolItem clickPoolItem = _queue.Dequeue();

            clickPoolItem.OnGetFromPool();

            return clickPoolItem;
        }

        public void ReturnToPool(ClickPoolItem item)
        {
            _queue.Enqueue(item);
        }

        protected void ExpanPool()
        {
            for (int i = 0; i < _size; i++)
            {
                CreateItem();
            }
        }

        protected ClickPoolItem CreateItem()
        {
            GameObject itemInstance = Instantiate(_clickPrefab);
            itemInstance.SetActive(false);

            ClickPoolItem clickPoolItem = itemInstance.GetComponent<ClickPoolItem>();
            clickPoolItem.Pool = this;

            _items.Add(clickPoolItem);
            _queue.Enqueue(clickPoolItem); 

            return clickPoolItem;
        }
    }
}
