using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyButtonBehaviour : MonoBehaviour
{
    void OnMouseUp()
    {
        GameManager.Instance.applyManager.Applied();
    }
}
