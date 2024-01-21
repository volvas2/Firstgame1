using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private float _speed;
    [SerializeField] private Movement _player;

    private Vector3 _posPlayer;
    
    private void Update()
    {
        Move();
                
        _posPlayer = _player.transform.position;
        float angle = Mathf.Atan2(_posPlayer.y, transform.position.x) * 
                Mathf.Rad2Deg + transform.eulerAngles.y;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    private void Move()
    {
        transform.position += transform.forward * _speed * Time.deltaTime;
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
