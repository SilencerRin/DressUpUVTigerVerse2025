//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using unityEngine.XR.Interaction.Toolkit;

public class EquipClothing : MonoBehaviour
{
    public GameObject clothingItem; // The clothing prefab to be equipped
    public GameObject currentClothing; // The currently equipped clothing item
    
    // Start is called before the first frame update
    private void OnTriggerEnter (collider other)
    {
        if (other.CompareTag("Player")) // Check if the player has entered the trigger area
        {
            if (currentClothing == null) // If no clothing is currently equipped
            {
                currentClothing = Instantiate(clothingItem, other.transform); // Instantiate the clothing item as a child of the player
                currentClothing.transform.localPosition = Vector3.zero; // Set the position to zero relative to the player
                currentClothing.transform.localRotation = Quaternion.identity; // Set the rotation to identity
            }
            else // If clothing is already equipped
            {
                Destroy(currentClothing); // Destroy the currently equipped clothing item
                currentClothing = null; // Reset the reference to the current clothing item
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the player has exited the trigger area
        {
            if (currentClothing != null) // If clothing is currently equipped
            {
                Destroy(currentClothing); // Destroy the currently equipped clothing item
                currentClothing = null; // Reset the reference to the current clothing item
            }
        }
    }
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
