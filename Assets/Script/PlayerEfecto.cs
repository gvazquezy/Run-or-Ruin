using UnityEngine;

public class PlayerEfecto : MonoBehaviour
{
    public float startSpawn;
    private float timeSpawn;
    public GameObject tailPrefab;

    private void Update()
    {
        if (timeSpawn <= 0)
        {
            Tail(); // Llama a la función Tail en lugar de Instantiate
            timeSpawn = startSpawn;
        }
        else
        {
            timeSpawn -= Time.deltaTime;
        }
    }

    void Tail()
    {
        var Tail = Instantiate(tailPrefab, transform.position, Quaternion.identity);
        Destroy(Tail, 0.5f);
    }
}