﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QUIT : MonoBehaviour {
    public void doQuit()
    {
        Debug.Log("has quit game");
        Application.Quit();
    }
}
