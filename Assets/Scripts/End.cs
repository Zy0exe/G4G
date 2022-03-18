using UnityEngine;

public class End : MonoBehaviour
{
    // Aqui é so para fechar o jogo
    /*
        Nota: o Application.Quit() não veja o jogo no unity porque não tá em modo "aplicação"
        so quando é exportado é que funciona.
    */
    public void Quit(){
        Debug.Log("Quit");
        Application.Quit();
    }
}
