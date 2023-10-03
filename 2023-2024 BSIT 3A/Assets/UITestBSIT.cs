using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITestBSIT : MonoBehaviour
{
    public TextMeshProUGUI TextToChange;
    public string TextOutput = "This is changed.";

    public void ChangeText ()
    {
        TextToChange.text = TextOutput;
    }
}
