using Letter.Generator;
using UnityEngine;

public class ComparisonGrid : MonoBehaviour, ILetterComparable
{
    [Header("Letter Comparison Setting")]
    public char letter = 'a';

    public bool IsCorrect { get; private set; }

    public void LetterAdded() => IsCorrect = VerifyLetter(transform.GetChild(0).GetComponent<LetterGeneration>().letter);

    public void LetterRemoved() => IsCorrect = false;

    public bool VerifyLetter(char letter)
    {
        if (letter == this.letter)
            return true;
        else
            return false;
    }
}
