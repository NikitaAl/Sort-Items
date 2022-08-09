using UnityEngine;

namespace SortItems
{
    public class LevelSwap : MonoBehaviour
    {
        public GameObject NewPref;
        public GameObject OldPref;


        
        void Start()
        {

        }

        
        void Update()
        {
            if ( OldPref != null)
            {
                Instantiate (NewPref, OldPref.transform.position, OldPref.transform.rotation); 
                Destroy(OldPref);
            }   
        }
    }
}
