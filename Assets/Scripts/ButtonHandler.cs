using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public TMP_InputField textField; 
    // Start is called before the first frame update
    public void ApplicationQuit () {
        Application.Quit();
    }

    public void startGame() {
        DataManager.Instance.setName(textField.text);
        SceneManager.LoadScene("main");
    }


}
