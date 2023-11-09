using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_trigger_script : MonoBehaviour
{
    public GameObject roadSection;

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("section_trigger_collider")){
            Instantiate(roadSection, new Vector3(0, 0, -4), Quaternion.identity);
        }
    }
}
