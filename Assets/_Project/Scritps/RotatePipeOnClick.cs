using UnityEngine;

public class RotatePipeOnClick : MonoBehaviour {

    public float m_angleOfRotation = 90f;

    public float amplitude = 0.5f;
    public float frequency = 1f;

    public void OnMouseDown()
    {
        gameObject.transform.Rotate(m_angleOfRotation, transform.rotation.y, transform.rotation.z, Space.Self);
    }
}
