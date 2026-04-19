using UnityEngine;
using UnityEngine.UI;

public class CustomizationToggles : MonoBehaviour
{
    public Toggle hatsToggle;
    public Toggle accessoriesToggle;
    public Toggle armorToggle;

    public GameObject hatImage;
    public GameObject accessoryImage;
    public GameObject armorImage;

    private void Start()
    {
        hatsToggle.onValueChanged.AddListener(ToggleHat);
        accessoriesToggle.onValueChanged.AddListener(ToggleAccessory);
        armorToggle.onValueChanged.AddListener(ToggleArmor);

        ApplyCurrentStates();
    }

    private void ApplyCurrentStates()
    {
        if (hatsToggle.isOn)
        {
            ShowOnlyHat();
        }
        else if (accessoriesToggle.isOn)
        {
            ShowOnlyAccessory();
        }
        else if (armorToggle.isOn)
        {
            ShowOnlyArmor();
        }
        else
        {
            HideAll();
        }
    }

    private void ToggleHat(bool isOn)
    {
        if (isOn)
        {
            hatsToggle.isOn = true;
            accessoriesToggle.isOn = false;
            armorToggle.isOn = false;
            ShowOnlyHat();
        }
        else if (!accessoriesToggle.isOn && !armorToggle.isOn)
        {
            HideAll();
        }
    }

    private void ToggleAccessory(bool isOn)
    {
        if (isOn)
        {
            hatsToggle.isOn = false;
            accessoriesToggle.isOn = true;
            armorToggle.isOn = false;
            ShowOnlyAccessory();
        }
        else if (!hatsToggle.isOn && !armorToggle.isOn)
        {
            HideAll();
        }
    }

    private void ToggleArmor(bool isOn)
    {
        if (isOn)
        {
            hatsToggle.isOn = false;
            accessoriesToggle.isOn = false;
            armorToggle.isOn = true;
            ShowOnlyArmor();
        }
        else if (!hatsToggle.isOn && !accessoriesToggle.isOn)
        {
            HideAll();
        }
    }

    private void ShowOnlyHat()
    {
        hatImage.SetActive(true);
        accessoryImage.SetActive(false);
        armorImage.SetActive(false);
    }

    private void ShowOnlyAccessory()
    {
        hatImage.SetActive(false);
        accessoryImage.SetActive(true);
        armorImage.SetActive(false);
    }

    private void ShowOnlyArmor()
    {
        hatImage.SetActive(false);
        accessoryImage.SetActive(false);
        armorImage.SetActive(true);
    }

    private void HideAll()
    {
        hatImage.SetActive(false);
        accessoryImage.SetActive(false);
        armorImage.SetActive(false);
    }
}