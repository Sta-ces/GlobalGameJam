using UnityEngine;

public class RotatePipeOnClick : MonoBehaviour {

    public float m_angleOfRotation = 90f;

    public void OnMouseDown()
    {
        gameObject.transform.Rotate(transform.rotation.x, m_angleOfRotation, transform.rotation.z, Space.World);
    }
}
