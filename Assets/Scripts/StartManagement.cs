using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StartManagement : MonoBehaviour
{
    public TextMeshProUGUI BestScore;
    
    // Start is called before the first frame update
    void Start()
    {
        BestScore.text = $"Best score {DataManager.Instance.bestScoreUser} : {DataManager.Instance.bestScoreValue}";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  
}
