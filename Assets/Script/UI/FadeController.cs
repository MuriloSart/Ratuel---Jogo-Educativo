using System.Collections;
using UnityEngine;

public class FadeController : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public float fadeDuration = 1f;

    private void Awake()
    {
        if (canvasGroup == null)
            canvasGroup = GetComponent<CanvasGroup>();
    }

    private void Start()
    {
        StartFadeOut();
    }

    public void StartFadeOut(System.Action onComplete = null)
    {
        StartCoroutine(Fade(1, 0, onComplete));
    }

    public void StartFadeIn(System.Action onComplete = null)
    {
        StartCoroutine(Fade(0, 1, onComplete));
    }

    private IEnumerator Fade(float start, float end, System.Action onComplete)
    {
        float time = 0f;
        canvasGroup.blocksRaycasts = true;
        canvasGroup.interactable = false;

        while (time < fadeDuration)
        {
            time += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(start, end, time / fadeDuration);
            yield return null;
        }

        canvasGroup.alpha = end;
        canvasGroup.blocksRaycasts = end == 1;
        canvasGroup.interactable = end == 1;

        onComplete?.Invoke();
    }
}