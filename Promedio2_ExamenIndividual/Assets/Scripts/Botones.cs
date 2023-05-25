using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Botones : MonoBehaviour
{
    public Text counterText;
    protected int counter = 0;

    protected void UpdateCounterText()
    {
        counterText.text = "Puntaje: " + counter.ToString();
    }
}
