using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CharacterSelector : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public Image previewImage;
    public TMP_InputField nameInput;
    public TMP_InputField ageInput;
    public TMP_Text resultText;

    public Sprite skeletonSprite;
    public Sprite fallenAngelSprite;
    public Sprite forestRangerSprite;

    void Start()
    {
        dropdown.onValueChanged.AddListener(OnDropdownChanged);
        OnDropdownChanged(0);
    }

    void OnDropdownChanged(int index)
    {
        switch (index)
        {
            case 0:
                previewImage.sprite = skeletonSprite;
                break;
            case 1:
                previewImage.sprite = fallenAngelSprite;
                break;
            case 2:
                previewImage.sprite = forestRangerSprite;
                break;
        }

        UpdateResult();
    }

    public void UpdateResult()
    {
        string charName = nameInput.text;
        string age = ageInput.text;
        string selectedClass = dropdown.options[dropdown.value].text;

        resultText.text =
            "Name: " + charName + "\n" +
            "Age: " + age + "\n" +
            "Class: " + selectedClass;
    }
}