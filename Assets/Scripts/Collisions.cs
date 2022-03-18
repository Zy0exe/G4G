using UnityEngine;

public class Collisions : MonoBehaviour
{
    public Player movement;

    void OnCollisionEnter(Collision collisionInfo) 
    {
        //@Zyo Não funciona o jogo termina sozinho 
        if (collisionInfo.collider.tag == "obstacle") {
            //movement.enabled = false;
            //FindObjectOfType<GameManager>().EndGame();
        }
    }
}
