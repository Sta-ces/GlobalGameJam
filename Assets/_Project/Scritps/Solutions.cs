using System.Collections.Generic;
using UnityEngine;

public class Solutions : MonoBehaviour {

    public GameObject m_ObjectToConnect1;
    public GameObject m_ObjectToConnect2;
    public bool m_solved;

    public void PipeSolved(bool _bool)
    {
        m_solved = _bool;
    }

    private void Update()
    {
        int countTrigger = 0;

        foreach(GameObject obj in TriggerList)
        {
            if (obj == m_ObjectToConnect1)
                countTrigger++;
            if (obj == m_ObjectToConnect2)
                countTrigger++;
        }

        if (countTrigger == 2)
            PipeSolved(true);
        else
            PipeSolved(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (!TriggerList.Contains(other.gameObject))
            TriggerList.Add(other.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        if (TriggerList.Contains(other.gameObject))
            TriggerList.Remove(other.gameObject);
    }

    private List<GameObject> TriggerList = new List<GameObject>();
}
