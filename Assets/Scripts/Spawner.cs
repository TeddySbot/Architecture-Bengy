using UnityEngine;

public class Spawner : MonoBehaviour
{
    private Vector2 pos;
    So_Enemy enemy;

    private void SpawnEnemy()
    {
        pos = new Vector2(Random.Range(-10f, 10f), Random.Range(-10f, 10f));
        Instantiate(enemy, pos, Quaternion.identity);
    }
}
