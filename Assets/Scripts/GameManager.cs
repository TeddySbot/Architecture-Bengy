using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Health = 100;

    private void BaselsDead()
    {
        if (Health <= 0)
            Debug.Log("Basel is dead");
    }
}
