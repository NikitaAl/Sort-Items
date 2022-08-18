using UnityEngine;

namespace SortItems
{
    public class ItemHideFx : MonoBehaviour
    {
        [SerializeField] private VPXPoolProvider _vpxPoolProvider;
        // [SerializeField] private GameObject _hideFxPrefab;

        public void Hide()
        {
            // Instantiate(_hideFxPrefab, transform.position, Quaternion.identity, null);

            VFXPoolItem poolItem = _vpxPoolProvider.VFXPool.GetFromPool();
            poolItem.transform.position = transform.position;
            poolItem.ParticleSystem.Play();

            Destroy(this.gameObject); 
        }

    }
}
