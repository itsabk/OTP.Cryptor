using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CopyText : MonoBehaviour
{
    public Text txt;
    string text;


    public void Start()
    {
        text = txt.text.ToString();
        UniClipboard.SetText(text);
    }
}
