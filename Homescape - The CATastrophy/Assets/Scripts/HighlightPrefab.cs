using UnityEngine;

public class PrefabHighlighter : MonoBehaviour
{
    public Material highlightMaterial; // The material to apply for highlighting
    private Material[] originalMaterials; // To store original materials
    private MeshRenderer[] meshRenderers; // All MeshRenderers in the prefab

    private void Start()
    {
        // Get all MeshRenderers in the prefab
        meshRenderers = GetComponentsInChildren<MeshRenderer>();
        // Store the original materials
        originalMaterials = new Material[meshRenderers.Length];
        for (int i = 0; i < meshRenderers.Length; i++)
        {
            originalMaterials[i] = meshRenderers[i].material;
        }
    }

    public void EnableHighlight()
    {
        // Replace all materials with the highlight material
        foreach (var renderer in meshRenderers)
        {
            renderer.material = highlightMaterial;
        }
    }

    public void DisableHighlight()
    {
        // Restore the original materials
        for (int i = 0; i < meshRenderers.Length; i++)
        {
            meshRenderers[i].material = originalMaterials[i];
        }
    }
}
