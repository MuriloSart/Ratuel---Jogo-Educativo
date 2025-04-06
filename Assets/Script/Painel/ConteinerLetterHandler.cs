using UnityEngine;

public class ConteinerLetterHandler : MonoBehaviour
{
    public AudioSource hitSound;
    public AudioSource missSound;

    public void ConferLetters()
    {
        bool allCorrect = true;

        for (int i = 0; i < transform.childCount; i++)
        {
            var child = transform.GetChild(i);
            var comparison = child.GetComponent<ComparisonGrid>();

            if (!comparison.IsCorrect)
            {
                allCorrect = false;
                break;
            }
        }

        if (allCorrect)
            hitSound.Play();
    }
}
