using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBall : MonoBehaviour
{
    public GameObject prefabBall;
    public Transform ballSpawn;

    private void OnTriggerEnter(Collider other)
    {
        // Destroy(other.gameObject);
        /* I used setactive(false) because interacton with the ball was not working after game object was destroyed
         The interactable worked with the ball only once in this case,  it worked when the ball appeared at its initial
        position on collision with the cube used to trigger the ball to spawn on collision.
        Since it only works once, I decided to use 
        "setActive(false)" so I  can give double tries. . .

        I am still looking for how to fix this and set it to multiple times I want.
         */
        gameObject.SetActive(false);
        Instantiate(prefabBall, ballSpawn.position, ballSpawn.rotation);
    }
}
