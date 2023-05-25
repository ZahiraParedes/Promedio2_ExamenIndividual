using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Boton1 : Botones
{
    public void ClickBoton1()
    {
        Action<int> action = GameManager.getInstance().UpdateScore;
        action(counter);
    }
}

