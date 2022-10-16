using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{


    public GameObject PrefabToSpawn;
    public Transform Parent;
    public Transform Reference;
    // Start is called before the first frame update
    void OnEnable()
    {
        GameObject x = Instantiate(PrefabToSpawn, Reference.position, Reference.rotation, Parent);
    }
    // Update is called once per frame
}
