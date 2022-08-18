using UnityEngine;
using UnityEngine.EventSystems;

namespace SortItems
{
    public class ItemClickFx : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] private GameObject _circleClickFxPrefab;


        public void OnPointerDown(PointerEventData eventData)
        {
            Instantiate(_circleClickFxPrefab, transform.position, Quaternion.identity, null);
        }
    }
}
