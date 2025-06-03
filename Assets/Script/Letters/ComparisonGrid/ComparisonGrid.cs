using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ComparisonGrid : MonoBehaviour, IComparable
{
    [Header("Letter Comparison Setting")]
    [SerializeField]private char letter = 'A';
    [SerializeField]private AudioSource hitSound;
    [SerializeField]private AudioSource errorSound;

    public bool IsCorrect { get; private set; }

    private Image image;

    private Color _normalColor;

    private void Awake()
    {
        letter = char.ToUpper(letter);
        image = GetComponent<Image>();
        _normalColor = image.color;

        if (transform.childCount > 0) LetterAdded();
    }

    public void LetterAdded() => IsCorrect = VerifyLetter(transform.GetChild(0).GetComponent<TextMeshProUGUI>().text[0]);

    public void LetterRemoved()
    {
        image.color = _normalColor;
        IsCorrect = false;
    }

    public bool VerifyLetter(char letter)
    {
        letter = char.ToUpper(letter);
        if (letter == this.letter)
        {
            image.color = Color.green;
            hitSound.Play();
            return true;
        }
        else
        {
            image.color = Color.red;
            errorSound.Play();
            return false;
        }
    }
}
