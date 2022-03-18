using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        /*
            Passamos a cam para a posição do player com ajuda da offset
        */
        transform.position = player.position + offset;
    }
}
