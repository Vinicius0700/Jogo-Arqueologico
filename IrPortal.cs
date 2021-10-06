using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IrPortal : MonoBehaviour
{
    public GameController gameController;
  
// mudar de cena
    public void irPorta(){
        Debug.Log("Colidiu com o portal");
        gameController.Level_1();
    }
}
