using UnityEngine;

public class PanelAndColliderSwitcher2 : MonoBehaviour
{
    public GameObject panelToClose;     // Panel to close
    public GameObject panelToOpen;      // Panel to open
    public GameObject doorToOpen;
    public GameObject doorToEnable; // The door's collider to enable
    public GameObject congratsPanel;
    public string targetTag = "Mug";    // Only a specific object can trigger

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag)) // Only the allowed object triggers this
        {
            panelToClose.SetActive(false);  // Hide the first panel
            panelToOpen.SetActive(true);    // Show the second panel
            doorToOpen.SetActive(false);
            doorToEnable.SetActive(true); // Enable the door's collider
            congratsPanel.SetActive(true);
        }
    }
}
