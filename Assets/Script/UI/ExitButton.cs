using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Fechando o jogo...");
        Application.Quit();
    }
}
