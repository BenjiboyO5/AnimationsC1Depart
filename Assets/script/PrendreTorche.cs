using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrendreTorche : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject _TorcheMur;
    [SerializeField] GameObject _TorcheMain;





    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
 
    }


    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){

            _TorcheMur.SetActive(false);
            _TorcheMain.SetActive(true);

        }
    }

}


