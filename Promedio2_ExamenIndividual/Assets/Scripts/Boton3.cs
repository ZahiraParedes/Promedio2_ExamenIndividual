using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Boton3 : Botones
{
    public void ClickBoton3()
    {
        Action<int> action = GameManager.getInstance().UpdateScore;
        action(counter);
    }
}

