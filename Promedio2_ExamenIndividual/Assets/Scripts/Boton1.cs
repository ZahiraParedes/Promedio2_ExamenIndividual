using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton1 : Botones
{
    public void ClickBoton1()
    {
        counter += 1;
        UpdateCounterText();
    }
}

