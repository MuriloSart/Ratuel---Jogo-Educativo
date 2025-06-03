using UnityEngine;
using UnityEngine.SceneManagement;

public class ConteinerLetterHandler : MonoBehaviour
{
    public AudioSource conquestSound;
    public FadeController fade;

    public void ConferLetters()
    {

        for (int i = 0; i < transform.childCount; i++)
        {
            var child = transform.GetChild(i);
            var comparison = child.GetComponent<ComparisonGrid>();

            if (!child.GetComponent<ComparisonGrid>()) continue;

            if (!comparison.IsCorrect) return;
        }

        if(conquestSound != null) conquestSound.Play();

        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        int totalScenes = SceneManager.sceneCountInBuildSettings;
        int nextIndex = currentIndex + 1;

        int targetSceneIndex = (nextIndex < totalScenes) ? nextIndex : 0;

        fade.StartFadeIn(() => {
            SceneManager.LoadScene(targetSceneIndex);
        });
    }
}
