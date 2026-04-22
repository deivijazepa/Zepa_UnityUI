using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CustomizationSelection : MonoBehaviour
{
    [Header("Category Toggles")]
    public Toggle hatsToggle;
    public Toggle accessoriesToggle;
    public Toggle armorToggle;

    [Header("Option Buttons")]
    public Button optionButton1;
    public Button optionButton2;
    public Button optionButton3;

    [Header("Option Button Labels")]
    public TMP_Text optionButton1Text;
    public TMP_Text optionButton2Text;
    public TMP_Text optionButton3Text;

    [Header("Selected Items Text")]
    public TMP_Text selectedItemsText;

    private enum Category
    {
        None,
        Hats,
        Accessories,
        Armor
    }

    private Category currentCategory = Category.None;

    private string selectedHat = "None";
    private string selectedAccessory = "None";
    private string selectedArmor = "None";

    private void Start()
    {
        hatsToggle.onValueChanged.AddListener(OnHatsToggleChanged);
        accessoriesToggle.onValueChanged.AddListener(OnAccessoriesToggleChanged);
        armorToggle.onValueChanged.AddListener(OnArmorToggleChanged);

        optionButton1.onClick.AddListener(() => SelectOption(0));
        optionButton2.onClick.AddListener(() => SelectOption(1));
        optionButton3.onClick.AddListener(() => SelectOption(2));

        if (hatsToggle.isOn)
        {
            currentCategory = Category.Hats;
        }
        else if (accessoriesToggle.isOn)
        {
            currentCategory = Category.Accessories;
        }
        else if (armorToggle.isOn)
        {
            currentCategory = Category.Armor;
        }
        else
        {
            currentCategory = Category.None;
        }

        UpdateOptionButtons();
        UpdateSelectedItemsText();
    }

    private void OnHatsToggleChanged(bool isOn)
    {
        if (isOn)
        {
            accessoriesToggle.isOn = false;
            armorToggle.isOn = false;
            currentCategory = Category.Hats;
        }
        else if (!accessoriesToggle.isOn && !armorToggle.isOn)
        {
            currentCategory = Category.None;
        }

        UpdateOptionButtons();
    }

    private void OnAccessoriesToggleChanged(bool isOn)
    {
        if (isOn)
        {
            hatsToggle.isOn = false;
            armorToggle.isOn = false;
            currentCategory = Category.Accessories;
        }
        else if (!hatsToggle.isOn && !armorToggle.isOn)
        {
            currentCategory = Category.None;
        }

        UpdateOptionButtons();
    }

    private void OnArmorToggleChanged(bool isOn)
    {
        if (isOn)
        {
            hatsToggle.isOn = false;
            accessoriesToggle.isOn = false;
            currentCategory = Category.Armor;
        }
        else if (!hatsToggle.isOn && !accessoriesToggle.isOn)
        {
            currentCategory = Category.None;
        }

        UpdateOptionButtons();
    }

    private void UpdateOptionButtons()
    {
        switch (currentCategory)
        {
            case Category.Hats:
                optionButton1Text.text = "Helmet";
                optionButton2Text.text = "Hood";
                optionButton3Text.text = "Crown";
                break;

            case Category.Accessories:
                optionButton1Text.text = "Ring";
                optionButton2Text.text = "Amulet";
                optionButton3Text.text = "Bracelet";
                break;

            case Category.Armor:
                optionButton1Text.text = "Light Armor";
                optionButton2Text.text = "Medium Armor";
                optionButton3Text.text = "Heavy Armor";
                break;

            default:
                optionButton1Text.text = "Option 1";
                optionButton2Text.text = "Option 2";
                optionButton3Text.text = "Option 3";
                break;
        }
    }

    private void SelectOption(int optionIndex)
    {
        switch (currentCategory)
        {
            case Category.Hats:
                if (optionIndex == 0) selectedHat = "Helmet";
                if (optionIndex == 1) selectedHat = "Hood";
                if (optionIndex == 2) selectedHat = "Crown";
                break;

            case Category.Accessories:
                if (optionIndex == 0) selectedAccessory = "Ring";
                if (optionIndex == 1) selectedAccessory = "Amulet";
                if (optionIndex == 2) selectedAccessory = "Bracelet";
                break;

            case Category.Armor:
                if (optionIndex == 0) selectedArmor = "Light Armor";
                if (optionIndex == 1) selectedArmor = "Medium Armor";
                if (optionIndex == 2) selectedArmor = "Heavy Armor";
                break;
        }

        UpdateSelectedItemsText();
    }

    private void UpdateSelectedItemsText()
    {
        selectedItemsText.text =
            "Selected Items:\n" +
            "Hat: " + selectedHat + "\n" +
            "Accessory: " + selectedAccessory + "\n" +
            "Armor: " + selectedArmor;
    }
}