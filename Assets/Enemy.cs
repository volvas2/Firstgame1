using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Enemy : MonoBehaviour
{
    public int health;
    public float speed;
    public Movement Player;
    
    void Update()
    {
        float angle = Mathf.Atan2(Player.transform.position.y - transform.position.y, Player.transform.position.x - transform.position.x) * Mathf.Rad2Deg + transform.eulerAngles.y;
        transform.rotation = Quaternion.Euler(0, 0, angle);
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
