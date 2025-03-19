using UnityEngine;

namespace Letter.Generator
{
    public class LetterGeneration : MonoBehaviour
    {
        [Header("Letter Settings")]
        public char letter = 'a';
        [SerializeField ]private AlphabetImageManager imageGenerator;

        private void Start()
        {
            ImageGeneration();
        }

        private void ImageGeneration()
        {
            AlphabetImageManager.Instance.GetLetterSprite(letter);
        }
    }
}
