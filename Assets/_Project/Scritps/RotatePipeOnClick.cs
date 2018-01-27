using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RotatePipeOnClick : MonoBehaviour {

    public float m_angleOfRotation = 90f;

    public void OnMouseDown()
    {
        gameObject.transform.Rotate(m_angleOfRotation, transform.rotation.y, transform.rotation.z);
    }
}
