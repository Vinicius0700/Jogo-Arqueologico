using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{

    public float velMin;
    public float velMax;
    public float correr;
    public float vel;
    
    //public GameController gameController;

    // Start is called before the first frame update]
    // não sei se pode perder os valores quando eu compartilho o codigo
    // coloquei no start so por garantia, mas eh algo que futuramente pretendo tirar
    void Start()
    {
        velMin = 4f;    //velocidade minima do personagem
        velMax = 7f;    //velocidade maxima do personagem
        vel = velMin;   //velocidade atual do personagem
        correr = 0.1f;  //Aceleração do personagem
    }

    // função apropriada pra mexer com update de fisicas do personagem
    private void FixedUpdate(){
        // conferir se o jogador vai correr ou não
        // vel < velmax eh pra evitar o acelere infinitamente
        if(Input.GetKey(KeyCode.LeftShift) && vel < velMax){
            vel += correr;
        }else if(!Input.GetKey(KeyCode.LeftShift) && vel > velMin){
            vel -= correr;
        }
        // Calcular o quanto o joogador se movel
        float direcaoUpDown= (Input.GetAxis("Vertical") * vel) * Time.fixedDeltaTime;
        float direcaoLeftHigth= (Input.GetAxis("Horizontal") * vel) * Time.fixedDeltaTime;
        // movimentar o jogador de acordo com o que foi passado nas variaveis
        transform.Translate(direcaoLeftHigth,direcaoUpDown,0);
        
    }
   
}
