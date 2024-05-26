using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData_New", menuName = "GameData")]
public class SO_GameData : ScriptableObject, ISerializationCallbackReceiver
{
    public int score = 0;

    public int lifes = 3;

    public Action OnLifeChange;

    void ISerializationCallbackReceiver.OnAfterDeserialize()
    {
        score = 0;
        lifes = 3;
        OnLifeChange = () => { };
    }


    void ISerializationCallbackReceiver.OnBeforeSerialize()
    { }

}

