using UnityEngine;

public class Spawner : MonoBehaviour
{
    private Vector2 pos;
    [SerializeField] private So_Enemy enemy;
    
    private void Start()
    {
        SpawnEnemy();
    }
    private void SpawnEnemy()
    {
        pos = new Vector2(Random.Range(-10f, 10f), Random.Range(-10f, 10f));
        Instantiate(enemy, pos, Quaternion.identity);
    }
}
