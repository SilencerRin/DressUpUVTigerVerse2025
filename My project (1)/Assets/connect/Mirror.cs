using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MirrorInteraction : MonoBehaviour
{
    public GameObject clothingMenu;  // Reference to the clothing menu UI

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            // Show clothing menu or trigger something in the mirror
            clothingMenu.SetActive(true);
        }
    }
}
