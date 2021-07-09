using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CopyText : MonoBehaviour
{
    public Text objText;
    string textVal;


    public void CopyToClipboard()
    {
        textVal = objText.text.ToString();
        UniClipboard.SetText(textVal);
        // text.CopyToClipboard();
    }
}
