using UnityEngine;
using UnityEngine.UI;

namespace Letter.Generator
{
    public class LetterGeneration : MonoBehaviour
    {
        [Header("Letter Settings")]
        public char letter = 'a';

        [ReadOnly] private Image image;

        private void Start()
        {
            image = GetComponent<Image>();
            ImageGeneration();
        }

        private void ImageGeneration()
        {
            image.sprite = AlphabetImageManager.Instance.GetLetterSprite(letter);
        }
    }
}
