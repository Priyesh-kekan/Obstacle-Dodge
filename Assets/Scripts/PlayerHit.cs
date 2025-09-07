using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHIt : MonoBehaviour
{
    private int hitCount = 0;
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("player collided");
        //Debug.Log(collision.gameObject.name);
        hitCount += 1;
        Debug.Log("Player has collided " + hitCount + "times");

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            ChangeColor(collision.gameObject, Color.black);
            GetComponent<Move>().enabled = false;
            ReloadScene();

        }
    }
    public static void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void ChangeColor(GameObject gameObject, Color color)
    {
        MeshRenderer meshRenderer = gameObject.GetComponent<MeshRenderer>();
        Material material = meshRenderer.material;
        material.color = Color.black;
    }
}
