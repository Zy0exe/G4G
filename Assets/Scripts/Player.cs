using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    // Jogador
    public Rigidbody rb;

    // Valores de salto velocidade etc
    public float forwardforce = 2000f;
    public float sidewaysforce = 750f;
    public float thrust;
    public float jumpCooldown = 3f;

    // Bools
    static bool canJump = true;

    /*
        No inicio do Jogo setamos o rb como o player.
    */
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    /*
        Fixed Update é melhor para tudo o que tenha a haver com inputs.
        este sistema de input é antigo o novo é mais facil e suporta comando.
    */
    void FixedUpdate() {
        if(Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        }

         if(Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardforce * Time.deltaTime);
        }

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey(KeyCode.Space) && canJump)
        {
            rb.AddForce(0, thrust, 0, ForceMode.Impulse);
            StartCoroutine(CoolDownFunction());
        }

        IEnumerator CoolDownFunction()
        {
            canJump = false;
            yield return new WaitForSeconds(jumpCooldown);
            canJump = true;
        }

        if (rb.position.y < -10f) {
            FindObjectOfType<GameManager>().EndGame();
        } 
    }

    /*
        Debug a cada frame do salto para returnar os valores do JumpCooldown e se pode saltar
    */
    void Update() {
        Debug.Log(jumpCooldown);
        Debug.Log(canJump);
    }
}
