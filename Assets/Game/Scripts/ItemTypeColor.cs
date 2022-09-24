using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SortItems
{
    [CreateAssetMenu(menuName = "My Assets/Color Data")]
    public class ItemTypeColor : ScriptableObject
    {
        public List<ItemColor> colors = new List<ItemColor>();

        private void OnValidate()
        {
            var colorCount =  System.Enum.GetValues(typeof(ItemType)).Length;

            if (colors.Count == 0)
                return;

            for (int i = 0; i < colorCount; i++)
            {
                if (i > colors.Count) 
                    break;

                var col = colors[i];
                col.name = (i < colorCount) ? ((ItemType)i).ToString() : "?????";
                Debug.Log(((ItemType)i).ToString());
                colors[i] = col;
            }
        }

        [System.Serializable]
        public struct ItemColor
        {
            public string name;
            public Color color;
            public Texture texture;
        }
    }
}
