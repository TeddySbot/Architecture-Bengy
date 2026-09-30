using UnityEngine;

[CreateAssetMenu(fileName = "So_Enemy", menuName = "Scriptable Objects/So_Enemy")]
public class So_Enemy : ScriptableObject
{
    private int damage;
    private int health;
    private int number;
    private int speed;

    private void TakeDMG(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            number--;
            Debug.Log("Enemy destroyed");
        }
    }

    private void applyDMG(int damage)
    {
        this.damage += damage;
        Debug.Log("Enemy took " + damage + " damage");
    }

    private void EnemyIsDead()
    {
        Debug.Log("Enemy is dead");
    }

    private void KillBase()
    {
        Debug.Log("Base killed");
    }

}
