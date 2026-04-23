using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelector : MonoBehaviour
{
    [Header("UI References")]
    public TMP_Dropdown characterDropdown;
    public Image previewImage;
    public TMP_InputField nameInput;
    public TMP_InputField ageInput;
    public TMP_Text resultText;
    public TMP_Text descriptionText;

    [Header("Character Sprites")]
    public Sprite skeletonSprite;
    public Sprite fallenAngelSprite;
    public Sprite forestRangerSprite;

    [Header("Forest Ranger Dress")]
    public GameObject dressPanel;
    public Image dressOverlayImage;
    public GameObject resetButton;

    private void Start()
    {
        if (characterDropdown != null)
        {
            characterDropdown.onValueChanged.AddListener(delegate
            {
                UpdateCharacter();
            });
        }

        if (nameInput != null)
        {
            nameInput.onValueChanged.AddListener(delegate
            {
                UpdateResultText();
            });
        }

        if (ageInput != null)
        {
            ageInput.onValueChanged.AddListener(delegate
            {
                UpdateResultText();
            });
        }

        UpdateCharacter();
        UpdateResultText();
    }

    public void UpdateCharacter()
    {
        if (characterDropdown == null || previewImage == null)
            return;

        int selected = characterDropdown.value;

        switch (selected)
        {
            case 0:
                // Skeleton Warrior
                previewImage.sprite = skeletonSprite;

                if (descriptionText != null)
                {
                    descriptionText.text =
                        "Skeleton Warrior is a fearless undead fighter.\n\n" +
                        "He is strong, battle-hardened, and wears ancient armor.\n\n" +
                        "Best suited for close combat and intimidating enemies.";
                }
                break;

            case 1:
                // Fallen Angel
                previewImage.sprite = fallenAngelSprite;

                if (descriptionText != null)
                {
                    descriptionText.text =
                        "Fallen Angel is a dark mystical protector.\n\n" +
                        "Fast, mysterious and powerful.\n\n" +
                        "Best suited for magic and shadow energy.";
                }
                break;

            case 2:
                // Forest Ranger
                previewImage.sprite = forestRangerSprite;

                if (descriptionText != null)
                {
                    descriptionText.text =
                        "Forest Ranger is a skilled protector of nature.\n\n" +
                        "Fast, observant and agile.\n\n" +
                        "Best suited for ranged combat and survival.";
                }
                break;
        }

        HandleForestRangerDress(selected);
        UpdateResultText();
    }

    private void HandleForestRangerDress(int selectedCharacter)
    {
        bool isForestRanger = (selectedCharacter == 2);

        if (dressPanel != null)
        {
            dressPanel.SetActive(isForestRanger);
        }

        if (resetButton != null)
        {
            resetButton.SetActive(isForestRanger);
        }

        if (!isForestRanger && dressOverlayImage != null)
        {
            dressOverlayImage.sprite = null;

            Color c = dressOverlayImage.color;
            c.a = 0f;
            dressOverlayImage.color = c;
        }
    }

    public void ResetForestRangerDress()
    {
        if (dressOverlayImage != null)
        {
            dressOverlayImage.sprite = null;

            Color c = dressOverlayImage.color;
            c.a = 0f;
            dressOverlayImage.color = c;
        }
    }

    public void UpdateResultText()
    {
        string enteredName = nameInput != null ? nameInput.text : "";
        string enteredAge = ageInput != null ? ageInput.text : "";
        string selectedClass = characterDropdown != null
            ? characterDropdown.options[characterDropdown.value].text
            : "Unknown";

        if (resultText != null)
        {
            resultText.text =
                "Name: " + enteredName + "\n" +
                "Age: " + enteredAge + "\n" +
                "Class: " + selectedClass;
        }
    }
}