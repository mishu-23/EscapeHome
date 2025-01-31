using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject menuCanvas; // Assign the Menu Canvas in the Inspector

    public void StartGame()
    {
        menuCanvas.SetActive(false); // Hides the entire menu
    }

    public void QuitGame()
    {
        Application.Quit(); // Exits the game (Only works in a build)
        Debug.Log("Game Quit!"); // Debug message for testing in Unity Editor
    }
}
