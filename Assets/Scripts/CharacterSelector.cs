using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterSelector : MonoBehaviour
{
    [Header("UI References")]
    public TMP_Dropdown dropdown;
    public Image previewImage;
    public TMP_InputField nameInput;
    public TMP_InputField ageInput;
    public TMP_Text resultText;
    public TMP_Text descriptionText;

    [Header("Character Sprites")]
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
                descriptionText.text =
                    "Skeleton Warrior is a fearless undead fighter.\n\n" +
                    "He is strong, battle-hardened, and wears ancient armor.\n\n" +
                    "Best suited for close combat and intimidating enemies.";
                break;

            case 1:
                previewImage.sprite = fallenAngelSprite;
                descriptionText.text =
                    "Fallen Angel is a dark mystical being.\n\n" +
                    "This character is mysterious, powerful, and connected to shadow energy.\n\n" +
                    "Best suited for magical or cursed-style customization.";
                break;

            case 2:
                previewImage.sprite = forestRangerSprite;
                descriptionText.text =
                    "Forest Ranger is a skilled protector of nature.\n\n" +
                    "Fast, observant, and agile, this character is perfect for survival and ranged combat.\n\n" +
                    "Best suited for stealth and wilderness adventures.";
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