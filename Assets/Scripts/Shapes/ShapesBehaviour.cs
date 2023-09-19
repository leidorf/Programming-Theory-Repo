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
        // Þeklin adý ve rengini ekrana yazdýr
        string info = "Shape Name: " + shapeName;
        infoText.text = info;
    }
    private void OnMouseDown()
    {
        // Þekil bilgilerini güncelle
        UpdateShapeInfo();
    }
}
