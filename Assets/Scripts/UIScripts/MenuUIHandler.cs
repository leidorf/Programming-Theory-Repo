#if UNITY_EDITOR
using UnityEditor;
#endif

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public static MenuUIHandler Instance;

    [SerializeField] private Button startButton;
    [SerializeField] private TMPro.TMP_InputField playerNameInput;
    private string playerName;


    private void Awake()
    {
        // Ensure there's only one instance of MenuUIHandler
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        PreStartButton();
    }

    void Update()
    {
        playerName = playerNameInput.text;
    }

    public string PlayerName 
    {
        get { return playerName; }
        set { playerName = value;}
    }
    private void PreStartButton()
    {
        startButton.interactable = false;
        playerNameInput.onValueChanged.AddListener(ShowStartButton);
    }

    //Method that shows start button if player enter name
    private void ShowStartButton(string inputText)
    {
        if (!string.IsNullOrEmpty(inputText))
        {
            startButton.interactable = true;
        }
        else
        {
            startButton.interactable = false;
        }
    }

    //Start game method
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    //Exit button method
    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

}
