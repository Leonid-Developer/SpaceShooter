using UnityEngine;
public class Player : MonoBehaviour
{
    public int points;

    public Projectile projectilePrefab;

    public float shootInterval;
    public float shootTimer;

    public Transform shootPoint;

    private void Update()
    {
        shootTimer -= Time.deltaTime;
        Shoot();
        Move();
    }

    void Move()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousPos = Input.mousePosition;
            Vector2 realpos = Camera.main.ScreenToWorldPoint(mousPos);
            transform.position = realpos;
        }
    }

    void Shoot()
    {
        if(shootTimer <= 0)
        {
            Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            shootTimer = shootInterval;
        }
    }
}
