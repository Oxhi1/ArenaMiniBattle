using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float dashBoost = 2f;
    public GameObject bulletPrefab;
    public Transform firePoint;

    Rigidbody2D rb;
    Vector2 move;

    int health = 5;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");

        if (Input.GetMouseButtonDown(0))
            Shoot();

        if (Input.GetKeyDown(KeyCode.Space))
            Dash();

        if (Input.GetKeyDown(KeyCode.Q))
            Heal();
    }

    void FixedUpdate()
    {
        rb.velocity = move * speed;
    }

    void Shoot()
    {
        if (bulletPrefab != null && firePoint != null)
        {
            var b = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Vector3 dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - firePoint.position;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90f;
            b.transform.rotation = Quaternion.Euler(0,0,angle);
        }
    }

    void Dash()
    {
        rb.velocity = rb.velocity * dashBoost;
    }

    void Heal()
    {
        health++;
        Debug.Log("Player healed: " + health);
    }

    public void TakeDamage(int dmg)
    {
        health -= dmg;
        Debug.Log("Player Health: " + health);
    }
}