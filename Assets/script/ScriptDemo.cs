using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDemo : MonoBehaviour
{


    string _monNom = "Cédric";

    int _age = 29;

    bool _verite = false;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(_age);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(_verite);
    }
}
