﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    void OnMouseDown()
    {
        GetComponent<DialogueTrigger>().TriggerDialogue();
    }
}