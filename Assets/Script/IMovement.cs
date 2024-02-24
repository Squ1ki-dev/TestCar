using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovement
{
    void HorizontalMovement(bool isLeftHold);
    void Stop();
}
