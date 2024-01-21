using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifetime;
    public float distance;
    public int damage;
    public LayerMask whatIsSolid;

    private Vector2 direction;
    private float speed;

    private void Start()
    {
        Destroy(gameObject, 2f);
    }

    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void SetDirection(Vector2 direction)
    {
        this.direction = direction;
    } 

    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<Enemy>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
