using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class XRSceneSwitcher : MonoBehaviour
{
    public string sceneToLoad; // Name of the scene to load

    private void Start()
    {
        // Ensure the GameObject has a Collider
        if (!GetComponent<Collider>())
        {
            Debug.LogError("No Collider found! Add a Collider to the GameObject.");
        }
    }

    public void ChangeScene()
    {
        Debug.Log("Switching scene to: " + sceneToLoad);
        SceneManager.LoadScene(sceneToLoad);
    }
}
