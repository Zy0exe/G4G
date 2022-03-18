using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    /*
        Menu do Jogo (simples não tenho paciencia para nada elaborado)
    */
    public void InitializeGame() {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
