using UnityEngine;
using UnityEngine.Events;

namespace SortItems
{
    public class ItemHideFx : MonoBehaviour
    {
        [SerializeField] private VPXPoolProvider _vpxPoolProvider;
       // [SerializeField] private GameObject _hideFxPrefab;
       public UnityEvent OnHide;

        public void Hide()
        {

            VFXPoolItem poolItem = _vpxPoolProvider.VFXPool.GetFromPool();
            poolItem.transform.position = transform.position;
            poolItem.ParticleSystem.Play();
            Destroy(this.gameObject);
        }

    }
}
