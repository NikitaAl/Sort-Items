using UnityEngine;

namespace SortItems
{
    public class CharacterAnimationPlayer : MonoBehaviour
    {
        
        [SerializeField] private Animator _animator;
        private static readonly int Sadidle = Animator.StringToHash("PlaySadidle");
        private static readonly int RumbaDancing = Animator.StringToHash("PlayRumbaDancing");

        public void PlaySadidle()
        {
            _animator.SetTrigger(Sadidle);
        }

        public void PlayRumbaDancing()
        {
            _animator.SetTrigger(RumbaDancing);
        }
    }
}
