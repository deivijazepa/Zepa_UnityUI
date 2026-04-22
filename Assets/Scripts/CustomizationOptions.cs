using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CustomizationOptions : MonoBehaviour
{
    [Header("Toggles")]
    public Toggle hatsToggle;
    public Toggle accessoriesToggle;
    public Toggle armorToggle;

    [Header("Panels")]
    public GameObject hatsPanel;
    public GameObject accessoriesPanel;
    public GameObject armorPanel;

    [Header("Selected Text")]
    public TMP_Text selectedItemsText;

    [Header("Character Sync")]
    public TMP_Dropdown characterDropdown;
    public Image characterImage;

    [Header("Overlay Images")]
    public Image accessoryImage;
    public Image armorImage;

    [Header("Full Character Sprites")]
    public Sprite characterOption1;
    public Sprite characterOption2;
    public Sprite characterOption3;

    [Header("Accessory Sprites")]
    public Sprite accessoryOption1;
    public Sprite accessoryOption2;
    public Sprite accessoryOption3;

    [Header("Armor Sprites")]
    public Sprite armorOption1;
    public Sprite armorOption2;
    public Sprite armorOption3;

    private string selectedHat = "None";
    private string selectedAccessory = "None";
    private string selectedArmor = "None";

    private void Start()
    {
        hatsToggle.onValueChanged.AddListener(OnHatsToggleChanged);
        accessoriesToggle.onValueChanged.AddListener(OnAccessoriesToggleChanged);
        armorToggle.onValueChanged.AddListener(OnArmorToggleChanged);

        hatsToggle.isOn = true;
        accessoriesToggle.isOn = false;
        armorToggle.isOn = false;

        UpdatePanels();
        UpdateText();

        if (accessoryImage != null)
            accessoryImage.enabled = false;

        if (armorImage != null)
            armorImage.enabled = false;
    }

    private void OnHatsToggleChanged(bool isOn)
    {
        if (isOn)
        {
            accessoriesToggle.isOn = false;
            armorToggle.isOn = false;
        }

        UpdatePanels();
    }

    private void OnAccessoriesToggleChanged(bool isOn)
    {
        if (isOn)
        {
            hatsToggle.isOn = false;
            armorToggle.isOn = false;
        }

        UpdatePanels();
    }

    private void OnArmorToggleChanged(bool isOn)
    {
        if (isOn)
        {
            hatsToggle.isOn = false;
            accessoriesToggle.isOn = false;
        }

        UpdatePanels();
    }

    private void UpdatePanels()
    {
        hatsPanel.SetActive(hatsToggle.isOn);
        accessoriesPanel.SetActive(accessoriesToggle.isOn);
        armorPanel.SetActive(armorToggle.isOn);
    }

    public void SelectHat1()
    {
        selectedHat = "Helmet";
        if (characterImage != null && characterOption1 != null)
            characterImage.sprite = characterOption1;
        if (characterDropdown != null)
            characterDropdown.value = 0;
        UpdateText();
    }

    public void SelectHat2()
    {
        selectedHat = "Hood";
        if (characterImage != null && characterOption2 != null)
            characterImage.sprite = characterOption2;
        if (characterDropdown != null)
            characterDropdown.value = 1;
        UpdateText();
    }

    public void SelectHat3()
    {
        selectedHat = "Crown";
        if (characterImage != null && characterOption3 != null)
            characterImage.sprite = characterOption3;
        if (characterDropdown != null)
            characterDropdown.value = 2;
        UpdateText();
    }

    public void SelectAccessory1()
    {
        selectedAccessory = "Ring";
        if (accessoryImage != null)
        {
            accessoryImage.sprite = accessoryOption1;
            accessoryImage.enabled = true;
        }
        UpdateText();
    }

    public void SelectAccessory2()
    {
        selectedAccessory = "Amulet";
        if (accessoryImage != null)
        {
            accessoryImage.sprite = accessoryOption2;
            accessoryImage.enabled = true;
        }
        UpdateText();
    }

    public void SelectAccessory3()
    {
        selectedAccessory = "Bracelet";
        if (accessoryImage != null)
        {
            accessoryImage.sprite = accessoryOption3;
            accessoryImage.enabled = true;
        }
        UpdateText();
    }

    public void SelectArmor1()
    {
        selectedArmor = "Light Armor";
        if (armorImage != null)
        {
            armorImage.sprite = armorOption1;
            armorImage.enabled = true;
        }
        UpdateText();
    }

    public void SelectArmor2()
    {
        selectedArmor = "Medium Armor";
        if (armorImage != null)
        {
            armorImage.sprite = armorOption2;
            armorImage.enabled = true;
        }
        UpdateText();
    }

    public void SelectArmor3()
    {
        selectedArmor = "Heavy Armor";
        if (armorImage != null)
        {
            armorImage.sprite = armorOption3;
            armorImage.enabled = true;
        }
        UpdateText();
    }

    private void UpdateText()
    {
        selectedItemsText.text =
            "Selected Items:\n" +
            "Hat: " + selectedHat + "\n" +
            "Accessory: " + selectedAccessory + "\n" +
            "Armor: " + selectedArmor;
    }
}