using UnityEngine;
using UnityEngine.SceneManagement;

/*
    Game Manager da handle a maioria das funções do jogo Acabar reiniciar e passar de nivel
*/

public class GameManager : MonoBehaviour
{
    bool HasEnded = false;
    public float RestartDelay = 3f;

    public GameObject completeLevelUi;

    public void CompleteLevel() {
        completeLevelUi.SetActive(true);
    }

    public void EndGame() {
        if (HasEnded == false)
        {
            HasEnded = true;
            Debug.Log("Game Over!");
            Invoke("Restart", RestartDelay);
            Restart();
        }
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
