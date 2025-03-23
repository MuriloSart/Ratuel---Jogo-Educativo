using UnityEngine;

public class ConteinerLetterHandler : MonoBehaviour
{
    public void ConferLetters()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            if (!child.GetComponent<ComparisonGrid>().IsCorrect) break;
        }
    }
}
