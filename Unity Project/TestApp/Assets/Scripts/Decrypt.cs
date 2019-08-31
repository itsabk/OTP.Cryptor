using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Decrypt : MonoBehaviour{

    public InputField c;
    public InputField k;
    public Text msgtxt;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ClickDecrypt(){
        string msg = c.text;
        string key = k.text;
        msgtxt.text = otpD(msg, key) + "";}

    float nMod(float a, float b) { return a - b * Mathf.Floor(a / b); } // Mod func for negative values

    private string otpD(string c, string k)
    {   string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string msgtext = "";
        for (int i = 0; i < c.Length; i++){
            int mv = 0, kv = 0;
            float cv;
            if (c[i] > 64 & c[i] < 91) { mv = c[i] - 65;  }
            if (k[i] > 64 & k[i] < 91) { kv = k[i] - 65; }
            if (c[i] > 96 & c[i] < 123) { mv = c[i] - 97;}
            if (k[i] > 96 & k[i] < 123) { kv = k[i] - 97; }
            cv = mv - kv;
            if (cv < 0) { cv = nMod(cv, 26); }
            if (cv >= 0) { cv = cv % 26; }
            msgtext += alphabets[(int)cv];}
        return msgtext;}}
