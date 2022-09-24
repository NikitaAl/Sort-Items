using UnityEngine;
using UnityEngine.Events;

namespace SortItems
{
    public class Getter : MonoBehaviour
    {

        [SerializeField] private ItemType type;

        private DragItem _item;

        private Material _material;

        private Color _defaultColor;

        private int targetCount = 1;

        private int count = 0;

        private bool active = true;

        public UnityEvent<Getter> onCountChanged;

        public ItemType Type { get => type; }

        [SerializeField] private ItemTypeColor _typeColor;

        public void SetCount(int value)
        {
            targetCount = value;

            if (count >= targetCount)
            {
                _material.color = Color.gray;
                active = false;
            }
        }

        private void Start() {
            _material = GetComponent<MeshRenderer>().material;
            if (_typeColor.colors[(int)Type].texture != null)
            {
                _material.mainTexture = _typeColor.colors[(int)Type].texture;
                _material.color = Color.white;
            }
            else
            {
                _material.color = _typeColor.colors[(int)Type].color;
            }
            
            _defaultColor = _material.color;
        }

        private void OnTriggerStay(Collider other) 
        {
            if(!active)
                return;

            var item = other.attachedRigidbody.GetComponent<DragItem>();

            if (item != null && item.isDraggable == true) 
            {
                _item = item;

                if ( _item.Type == Type)
                {
                    _material.color = Color.green;
                }
                else
                {
                    _material.color = Color.red;
                }

                return;
            }

            if (item.isDraggable == false && _item == item)
            {
                TryGetItem();
                _item = null;
                _material.color = _defaultColor;

                return;
            }
        }

        private void OnTriggerExit(Collider other) 
        {
            if(!active)
            return;
               
            var item = other.attachedRigidbody.GetComponent<DragItem>();

            if (_item == item)
            {
                _material.color = _defaultColor; 

                if (item.isDraggable == false)
                    TryGetItem();
            

                _item = null;
            }
        }

        private void TryGetItem()
        {
            if ( _item.Type == Type)
            {
                count++;
                if (count >= targetCount)
                {
                    _material.color = Color.gray;
                    active = false;
                }

                onCountChanged.Invoke(this);
                // Destroy(_item.gameObject); 
                
                _item.OnHideRequest.Invoke();

            }
        }
    }
}
