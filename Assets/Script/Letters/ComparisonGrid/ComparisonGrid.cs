using TMPro;
using UnityEngine;

public class ComparisonGrid : MonoBehaviour, IComparable
{
    [Header("Letter Comparison Setting")]
    public char letter = 'A';

    public bool IsCorrect { get; private set; }


    private void Awake()
    {
        letter = char.ToUpper(letter);

        if (transform.childCount > 0)
            LetterAdded();
    }

    public void LetterAdded() => IsCorrect = VerifyLetter(transform.GetChild(0).GetComponent<TextMeshProUGUI>().text[0]);

    public void LetterRemoved() => IsCorrect = false;

    public bool VerifyLetter(char letter)
    {
        if (letter == this.letter)
            return true;
        else
            return false;
    }
}
