using UnityEngine;

public class Tower
{
    public int domage;
    public int Health;
    private int numberOfTowers;

    private void TakeDMG(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            numberOfTowers--;
            Debug.Log("Tower destroyed");
        }
    }

    private void applyDMG(int damage)
    {
        domage += damage;
        Debug.Log("Tower took " + damage + " damage");
    }

    private void KillEnemy()
    {
        Debug.Log("Enemy killed");
    }
}
