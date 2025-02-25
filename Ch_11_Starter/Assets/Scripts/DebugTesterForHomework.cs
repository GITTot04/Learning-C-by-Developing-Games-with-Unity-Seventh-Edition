using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTesterForHomework : MonoBehaviour
{
    CombatManager myCM = new CombatManager();
    void Start()
    {
        myCM.Initialize();
    }
}
