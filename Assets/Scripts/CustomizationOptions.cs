using UnityEngine;
using UnityEngine.UI;

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

    [Header("Preview Images")]
    public Image hatImage;
    public Image accessoryImage;
    public Image armorImage;

    [Header("Hat Sprites")]
    public Sprite hatOption1;
    public Sprite hatOption2;
    public Sprite hatOption3;

    [Header("Accessory Sprites")]
    public Sprite accessoryOption1;
    public Sprite accessoryOption2;
    public Sprite accessoryOption3;

    [Header("Armor Sprites")]
    public Sprite armorOption1;
    public Sprite armorOption2;
    public Sprite armorOption3;

    private void Start()
    {
        hatsToggle.onValueChanged.AddListener(OnHatsToggleChanged);
        accessoriesToggle.onValueChanged.AddListener(OnAccessoriesToggleChanged);
        armorToggle.onValueChanged.AddListener(OnArmorToggleChanged);

        UpdatePanels();
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

    public void SelectHat1() => hatImage.sprite = hatOption1;
    public void SelectHat2() => hatImage.sprite = hatOption2;
    public void SelectHat3() => hatImage.sprite = hatOption3;

    public void SelectAccessory1() => accessoryImage.sprite = accessoryOption1;
    public void SelectAccessory2() => accessoryImage.sprite = accessoryOption2;
    public void SelectAccessory3() => accessoryImage.sprite = accessoryOption3;

    public void SelectArmor1() => armorImage.sprite = armorOption1;
    public void SelectArmor2() => armorImage.sprite = armorOption2;
    public void SelectArmor3() => armorImage.sprite = armorOption3;
}