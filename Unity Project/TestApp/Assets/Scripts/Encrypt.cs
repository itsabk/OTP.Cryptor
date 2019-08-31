using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Encrypt : MonoBehaviour {

    public InputField m;
    public InputField k;
    public Text cyphertxt;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ClickEncrypt()
    {
        string msg = m.text;
        string key = k.text;
        cyphertxt.text = otpE(msg, key) + "";

    }

    private string otpE(string m, string k)
    {
        int x = m.Length;
        string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string cyphertext = "";
        for (int i = 0; i < x; i++){
            int mv=0, kv=0;
            if (m[i] > 64 & m[i] < 91) { mv = m[i] - 65; }
            if (k[i] > 64 & k[i] < 91) { kv = k[i] - 65; }
            if (m[i] > 96 & m[i] < 123) { mv = m[i] - 97; }
            if (k[i] > 96 & k[i] < 123) { kv = k[i] - 97; }
            cyphertext += alphabets[(mv + kv) % 26];}
        return cyphertext;
    }

}
