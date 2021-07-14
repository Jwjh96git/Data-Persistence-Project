using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager instance;

    public string playerName;

    public Text nameText;

    void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    

    public void LoadMainScene()
    {
        playerName = nameText.text;
        SceneManager.LoadScene(1);
    }
}
