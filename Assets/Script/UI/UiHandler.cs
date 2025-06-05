using UnityEngine;

public class UiHandler : MonoBehaviour
{
    public GameObject menu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menu.SetActive(!menu.activeSelf);
        }
    }
}
