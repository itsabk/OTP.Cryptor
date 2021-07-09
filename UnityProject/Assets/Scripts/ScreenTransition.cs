using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenTransition : MonoBehaviour {

    public void Transition(int scrTransition)
    {
        SceneManager.LoadScene(scrTransition);
    }

}
