using UnityEngine;
public class Mover : MonoBehaviour
{
    public float speed = 2f;


    private void Start()
    {
        Destroy(gameObject, 5f);
    }

    private void Update()
    {
        transform.position = (Vector2)transform.position + Vector2.down * (speed + GameController.gameSpeed * Time.deltaTime);
    }
}
