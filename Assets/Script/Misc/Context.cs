using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Context : MonoBehaviour
{
    public CommonDevice currentDevice;
    public Interact human;
    public Interactable hand;
    public Context()
    {
        currentDevice = null;
        human = null;
        hand = null;
    }
}
