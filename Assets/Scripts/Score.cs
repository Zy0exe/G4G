using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text score;

    // Update is called once per frame
    void Update()
    {
        /*
            Conta o score consoante a posição z do player, a minha ideia seria meter uma parede invisivel atras do jogador desativando a mesh para ele nao conseguir andar para trás
            porque senao o score fica negativo
        */
        score.text = player.position.z.ToString("0");
    }
}
