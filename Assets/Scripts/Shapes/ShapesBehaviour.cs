using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class ShapesBehaviour : MonoBehaviour
{
    public string shapeName;
    public TMP_Text infoText;

    public void UpdateShapeInfo()
    {
        // �eklin ad� ve rengini ekrana yazd�r
        string info = "Shape Name: " + shapeName;
        infoText.text = info;
    }
    private void OnMouseDown()
    {
        // �ekil bilgilerini g�ncelle
        UpdateShapeInfo();
    }
}
