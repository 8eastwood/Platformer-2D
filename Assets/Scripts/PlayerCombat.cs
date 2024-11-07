using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    [SerializeField] private Transform _attackPoint;

    private int _attackDamage = 20;
    //private float _attackRange = 1f;
    //private bool _isAttack;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Enemy enemy) && Input.GetKeyDown(KeyCode.E))
        {
            Attack(enemy);
        }
    }

    public void Attack(Enemy enemy)
    {
        enemy.TakeDamage(_attackDamage);
    }
}
