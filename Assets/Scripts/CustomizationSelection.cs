using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CustomizationSelection : MonoBehaviour
{
    [Header("Toggles")]
    public Toggle hatsToggle;
    public Toggle accessoriesToggle;
    public Toggle armorToggle;

    [Header("Panels")]
    public GameObject hatsPanel;
    public GameObject accessoriesPanel;
    public GameObject armorPanel;

    [Header("Selected Items Text")]
    public TMP_Text selectedItemsText;

    private string selectedHat = "None";
    private string selectedAccessory = "None";
    private string selectedArmor = "None";

    private void Start()
    {
        hatsToggle.onValueChanged.AddListener(OnHatsToggleChanged);
        accessoriesToggle.onValueChanged.AddListener(OnAccessoriesToggleChanged);
        armorToggle.onValueChanged.AddListener(OnArmorToggleChanged);

        UpdatePanels();
        UpdateSelectedItemsText();
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
        UpdateSelectedItemsText();
    }

    public void SelectHat2()
    {
        selectedHat = "Hood";
        UpdateSelectedItemsText();
    }

    public void SelectHat3()
    {
        selectedHat = "Crown";
        UpdateSelectedItemsText();
    }

    public void SelectAccessory1()
    {
        selectedAccessory = "Ring";
        UpdateSelectedItemsText();
    }

    public void SelectAccessory2()
    {
        selectedAccessory = "Amulet";
        UpdateSelectedItemsText();
    }

    public void SelectAccessory3()
    {
        selectedAccessory = "Bracelet";
        UpdateSelectedItemsText();
    }

    public void SelectArmor1()
    {
        selectedArmor = "Light Armor";
        UpdateSelectedItemsText();
    }

    public void SelectArmor2()
    {
        selectedArmor = "Medium Armor";
        UpdateSelectedItemsText();
    }

    public void SelectArmor3()
    {
        selectedArmor = "Heavy Armor";
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