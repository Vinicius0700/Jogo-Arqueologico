using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteracaoComF : MonoBehaviour
{
    [SerializeField]
    private bool podeExecutar = false;
    [SerializeField]
    public GameController jogadorInteraje;
    [SerializeField]
    private UnityEvent botaoApertado;


    // Update is called once per frame
    void Update()
    {
        //confere se o player esta dentro do tigger
        if(podeExecutar == true){
            //confere se o player esta precionando o botão de interação
            if(jogadorInteraje.estaInteragindo == true){
                //não sei direito mas auxilia na interação do player com o objetoS
                botaoApertado.Invoke();
            }
        }
    }

// confere se o player esta dentro do tigger
    public void OnTriggerEnter2D(Collider2D collision) {
        
        if(collision.tag == "Player"){
            podeExecutar = true;
        }
    }
// confere se o player esta fora do tigger
    public void OnTriggerExit2D(Collider2D collision) {
        podeExecutar = false;
    }
}
