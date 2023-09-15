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
    [SerializeField] private Button startButton;
    [SerializeField] private TMPro.TMP_InputField playerNameInput;
  
    void Start()
    {
        startButton.interactable = false;
        playerNameInput.onValueChanged.AddListener(ShowStartButton);
    }

    void Update()
    {

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
