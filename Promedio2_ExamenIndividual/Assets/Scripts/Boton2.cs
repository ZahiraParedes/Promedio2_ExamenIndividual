using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Boton2 : Botones
{
    public void ClickBoton2()
    {
        Action<int> action = GameManager.getInstance().UpdateScore;
        action(counter);
    }
}

