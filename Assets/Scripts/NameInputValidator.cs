using TMPro;
using UnityEngine;

public class NameInputValidator : MonoBehaviour
{
    public TMP_InputField nameInput;

    public void ValidateName()
    {
        string input = nameInput.text;
        string filtered = "";

        foreach (char c in input)
        {
            if (char.IsLetter(c) || c == ' ' || c == '-')
            {
                filtered += c;
            }
        }

        if (nameInput.text != filtered)
            nameInput.text = filtered;
    }
}