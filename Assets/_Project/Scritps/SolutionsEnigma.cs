using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolutionsEnigma : MonoBehaviour {

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Pipe")
        {
            if (FindAWay.FindTheWay(other.gameObject))
                Debug.Log("Trouvez");
            else
                Debug.Log("Pas Trouvez");
        }
    }
}
