using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegarObjetos : MonoBehaviour
{
// desabilitando o objeto
    public void pegarObjetos(){
        Debug.Log("Peguei o objeto");
        gameObject.SetActive(false);
    }
}
