using UnityEngine;

public class ChangeClothesButton : MonoBehaviour
{
    public GameObject clothingToEquip;

    public void EquipClothing()
    {
        // This would be called when a button is clicked
        clothingToEquip.SetActive(true);
    }
}
