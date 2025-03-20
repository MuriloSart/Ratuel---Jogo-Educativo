using UnityEngine;

public class ConteinerLetterHandler : MonoBehaviour
{
    public void ConferLetters()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            Debug.Log(child.GetComponent<ComparisonGrid>().IsCorrect);
            if (!child.GetComponent<ComparisonGrid>().IsCorrect) break;
        }
    }
}
