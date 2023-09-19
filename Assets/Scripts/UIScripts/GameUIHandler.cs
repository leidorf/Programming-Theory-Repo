using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class GameUIHandler : MonoBehaviour
{
    [SerializeField] private TMP_Text playerText;
    private string pName;

    // Start is called before the first frame update
    void Start()
    {
        PrintPlayerName();
    }

    private void PrintPlayerName()
    {
        pName = MenuUIHandler.Instance.PlayerName;
        if (string.IsNullOrEmpty(pName))
        {
            playerText.text = "asd";
        }
        else
        {
            playerText.text = pName;
        }
    }
}
