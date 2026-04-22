using UnityEngine;
using UnityEngine.UI;

public class CharacterScaler : MonoBehaviour
{
    public Transform character;
    public Slider heightSlider;
    public Slider widthSlider;

    private Vector3 originalScale;

    private void Start()
    {
        originalScale = character.localScale;

        heightSlider.minValue = 0.8f;
        heightSlider.maxValue = 1.3f;
        heightSlider.value = 1f;

        widthSlider.minValue = 0.8f;
        widthSlider.maxValue = 1.3f;
        widthSlider.value = 1f;

        heightSlider.onValueChanged.AddListener(delegate { UpdateScale(); });
        widthSlider.onValueChanged.AddListener(delegate { UpdateScale(); });

        UpdateScale();
    }

    private void UpdateScale()
    {
        character.localScale = new Vector3(
            originalScale.x * widthSlider.value,
            originalScale.y * heightSlider.value,
            originalScale.z
        );
    }
}