using UnityEngine;

public class PanelAndColliderSwitcher : MonoBehaviour
{
    public GameObject panelToClose;     // Assign the panel to close
    public GameObject panelToOpen;      // Assign the panel to open
    public GameObject colliderToActivate; // Assign the second collider to activate
    public string targetTag = "Key"; // Change to the tag of the allowed object

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag)) // Only the specified object can trigger
        {
            panelToClose.SetActive(false);  // Hide the first panel
            panelToOpen.SetActive(true);    // Show the second panel
            colliderToActivate.SetActive(true); // Activate the second collider
            print("colider is on");
        }
    }
}
