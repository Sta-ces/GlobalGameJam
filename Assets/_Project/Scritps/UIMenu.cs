using UnityEngine;

public class UIMenu : MonoBehaviour {

    public float m_sizeToScale = 2f;


    private void OnMouseOver()
    {
        transform.localScale += Vector3.one * m_sizeToScale;
    }

    private void OnMouseExit()
    {
        transform.localScale = Vector3.one;
    }
}
