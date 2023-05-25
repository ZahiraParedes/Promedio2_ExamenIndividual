using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton2 : Botones
{
    public void ClickBoton2()
    {
        counter += 2;
        UpdateCounterText();
    }
}

