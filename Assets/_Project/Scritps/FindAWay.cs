using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindAWay : MonoBehaviour {
    
    public static bool FindTheWay(GameObject _object)
    {
        bool result = false;
        ConnectedToObject[] childsObject = _object.GetComponentsInChildren<ConnectedToObject>();

        foreach(ConnectedToObject child in childsObject)
        {
        }

        return result;
    }
}
