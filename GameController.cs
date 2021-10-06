using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public bool estaInteragindo;

    // pergunta se o player esta precionando o botão de interação
    void Update(){

        if(Input.GetButtonDown("Interage")){
            estaInteragindo = true;
        }else{
            estaInteragindo = false;
        }
    }

    // carregar a cena do primeiro mapa
    public void Level_1(){
        
        SceneManager.LoadScene("Level_1");

    }
}
