using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCInputConroller : MonoBehaviour
{
    public bool LeftMouseClick => Input.GetMouseButtonDown(0);
    public bool RightMouseClick => Input.GetMouseButtonDown(1);
}
