using System.Collections.Generic;
using UnityEngine;

namespace Letter.Generator
{
    public class AlphabetImageManager : Singleton<AlphabetImageManager>
    {
        public List<LetterSprite> letterSprites = new()
        {
            new LetterSprite{ letter = 'A', sprite = null },
            new LetterSprite{ letter = 'B', sprite = null },
            new LetterSprite{ letter = 'C', sprite = null },
            new LetterSprite{ letter = 'D', sprite = null },
            new LetterSprite{ letter = 'E', sprite = null },
            new LetterSprite{ letter = 'F', sprite = null },
            new LetterSprite{ letter = 'G', sprite = null },
            new LetterSprite{ letter = 'H', sprite = null },
            new LetterSprite{ letter = 'I', sprite = null },
            new LetterSprite{ letter = 'J', sprite = null },
            new LetterSprite{ letter = 'K', sprite = null },
            new LetterSprite{ letter = 'L', sprite = null },
            new LetterSprite{ letter = 'M', sprite = null },
            new LetterSprite{ letter = 'N', sprite = null },
            new LetterSprite{ letter = 'O', sprite = null },
            new LetterSprite{ letter = 'P', sprite = null },
            new LetterSprite{ letter = 'Q', sprite = null },
            new LetterSprite{ letter = 'R', sprite = null },
            new LetterSprite{ letter = 'S', sprite = null },
            new LetterSprite{ letter = 'T', sprite = null },
            new LetterSprite{ letter = 'U', sprite = null },
            new LetterSprite{ letter = 'V', sprite = null },
            new LetterSprite{ letter = 'W', sprite = null },
            new LetterSprite{ letter = 'X', sprite = null },
            new LetterSprite{ letter = 'Y', sprite = null },
            new LetterSprite{ letter = 'Z', sprite = null }
        };



        private Dictionary<char, Sprite> alphabetDictionary;

        public override void Awake()
        {
            base.Awake();

            alphabetDictionary = new Dictionary<char, Sprite>();

            foreach (var item in letterSprites)
            {
                if (!alphabetDictionary.ContainsKey(item.letter))
                {
                    alphabetDictionary.Add(item.letter, item.sprite);
                }
            }
        }

        public Sprite GetLetterSprite(char letter)
        {
            if (alphabetDictionary.TryGetValue(letter, out Sprite sprite)) return sprite;

            return null; 
        }
    }

    [System.Serializable]
    public class LetterSprite
    {
        public char letter;
        public Sprite sprite;
    }
}