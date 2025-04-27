using UnityEngine;
using UnityEngine.UI;

public class AvatarAppearance : MonoBehaviour
{
    public Renderer avatarRenderer;
    public Slider skinToneSlider;

    void Start()
    {
        skinToneSlider.onValueChanged.AddListener(ChangeSkinTone);
    }

    public void ChangeSkinTone(float value)
    {
        // You can map the slider value to a color
        Color skinColor = Color.Lerp(Color.white, Color.black, value);
        avatarRenderer.material.SetColor("_SkinColor", skinColor);
    }
}
