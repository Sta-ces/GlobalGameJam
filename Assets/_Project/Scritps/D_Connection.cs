using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D_Connection : MonoBehaviour {

    public bool m_Connected;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Pipe")
            Debug.Log(other.gameObject.name + " TOUCHE " + gameObject.name);
    }
}
