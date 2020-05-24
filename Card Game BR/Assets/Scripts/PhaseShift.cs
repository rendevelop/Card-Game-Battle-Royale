using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PhaseShift : ScriptableObject
{
    public abstract bool ShiftPhases(GameplayManager controller);
}
