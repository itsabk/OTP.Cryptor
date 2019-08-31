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
        text = GameObject.Find("CypheredText").GetComponent<Text>().ToString();
        UniClipboard.SetText(text);
    }
}
