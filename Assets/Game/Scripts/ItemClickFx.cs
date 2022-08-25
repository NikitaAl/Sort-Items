using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace SortItems
{
    public class ItemClickFx : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] private GameObject _circleClickFxPrefab;
        // [SerializeField] private ClickPoolProvider _clickPoolProvider;

        public UnityEvent OnClick;


        public void OnPointerDown(PointerEventData eventData)
        {
            Instantiate(_circleClickFxPrefab, transform.position, Quaternion.identity, null);

            // ClickPoolItem itemInstance = _clickPoolProvider.ClickPool.GetFromPool();
            // itemInstance.transform.position = transform.position;
            // itemInstance.ParticleSystem.Play();

            
            // ClickPoolItem poolItem = _clickPoolProvider.ClickPool.GetFromPool();
            // poolItem.transform.position = transform.position;
            // poolItem.ParticleSystem.Play();

            // Destroy(this.gameObject);

            OnClick.Invoke();

        }
    }
}
