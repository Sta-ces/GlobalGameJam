using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorPipePuzzle : MonoBehaviour {
    
    public List<GameObject> m_PrefabsPipes;
    public string m_NameCubeAutorized = "Floor_topPlateform";

    private void Awake()
    {
        GameObject[] cube = FindObjectsOfType<GameObject>();
       
        for(int c = 0; c < cube.Length; c++)
        {
            if (cube[c].name == m_NameCubeAutorized)
                m_cubePlateform.Add(cube[c].gameObject);
        }
    }

    private void Start()
    {
        GeneratePipeMap();
    }


    private void GeneratePipeMap()
    {
        foreach(GameObject cube in m_cubePlateform)
        {
            if (Randomizer() == 1)
            {
                GameObject pipe = m_PrefabsPipes[Randomizer(0, m_PrefabsPipes.Count)];
                GameObject newPipe = Instantiate(pipe, cube.transform.position, pipe.transform.rotation);
                newPipe.transform.localScale = new Vector3(0.075f, 0.075f, 0.075f);
                newPipe.transform.position += new Vector3(0, 0.85f, 0);
            }
        }
    }

    private int Randomizer(int _min = 0, int _max = 2)
    {
        return Random.Range(_min, _max);
    }

    private List<GameObject> m_cubePlateform = new List<GameObject>();
}
