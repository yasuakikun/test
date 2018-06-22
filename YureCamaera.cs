using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YureCamaera : MonoBehaviour
{
    public void Shake(GameObject shakeObject)
    {
        iTween.ShakePosition(shakeObject, iTween.Hash("x", 0.5f, "y", 0.5f, "time", 0.5f));
    }
    
}
