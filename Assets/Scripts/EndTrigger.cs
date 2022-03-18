using UnityEngine;

public class EndTrigger : MonoBehaviour
{
   public GameManager gameManager;


   /*
      Aqui temos um trigger para o cubo do "End" que quando o player bate na parede ele completa o nivel e passa para o proximo
   */
   void OnTriggerEnter(){
      gameManager.CompleteLevel();
   }
}
