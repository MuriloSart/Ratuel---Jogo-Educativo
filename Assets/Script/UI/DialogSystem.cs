using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueSystem : MonoBehaviour
{
    [Header("UI")]
    public TextMeshProUGUI dialogueText;
    public Button dialogueButton;

    [Header("Di�logo")]
    [TextArea]
    public string[] sentences;

    [Header("Transi��o")]
    public FadeController fadeController;
    public string nextSceneName;

    private int currentIndex = 0;

    void Start()
    {
        dialogueText.text = sentences[currentIndex];
        dialogueButton.onClick.AddListener(AdvanceDialogue);
    }

    void AdvanceDialogue()
    {
        currentIndex++;

        if (currentIndex < sentences.Length)
        {
            dialogueText.text = sentences[currentIndex];
        }
        else
        {
            dialogueButton.interactable = false;
            fadeController.StartFadeIn(() =>
            {
                SceneManager.LoadScene(nextSceneName);
            });
        }
    }
}
