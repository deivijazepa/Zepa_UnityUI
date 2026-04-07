using UnityEngine;
using UnityEngine.UI;

public class CharacterScaler : MonoBehaviour
{
    public Transform character;
    public Slider heightSlider;
    public Slider widthSlider;

    void Start()
    {
        heightSlider.onValueChanged.AddListener(UpdateScale);
        widthSlider.onValueChanged.AddListener(UpdateScale);
    }

    void UpdateScale(float value)
    {
        float height = heightSlider.value;
        float width = widthSlider.value;

        character.localScale = new Vector3(width, height, 1f);
    }
}