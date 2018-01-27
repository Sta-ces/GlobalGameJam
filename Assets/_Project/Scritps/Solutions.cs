using UnityEngine;

public class Solutions : MonoBehaviour {

    public GameObject m_pipeToTouch;
    public bool m_solved;

    public void PipeSolved(bool _bool)
    {
        m_solved = _bool;
    }

    private void Update()
    {
        float hitInfo = Vector3.Dot(transform.forward, (m_pipeToTouch.transform.position - transform.position).normalized);

        if (hitInfo > 0.75f)
            PipeSolved(true);
        else
            PipeSolved(false);
    }
}
