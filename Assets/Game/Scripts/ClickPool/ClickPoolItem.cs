using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SortItems
{
    public class ClickPoolItem : MonoBehaviour
    {
        [SerializeField] private ParticleSystem _particleSystem;

        public ParticleSystem ParticleSystem => _particleSystem;

        public ClickPool Pool { get; set;}

        private void OnParticleSystemStopped() 
        {
            ReturnToPool();
        }

        public void ReturnToPool()
        {
            Pool.ReturnToPool(this);
            gameObject.SetActive(false);
        }

        public void OnGetFromPool()
        {
            gameObject.SetActive(true);
        }
    }
}
