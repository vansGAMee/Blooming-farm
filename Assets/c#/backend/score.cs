using UnityEngine;

public class score : MonoBehaviour
{
    public GameObject objectToSpawn; // Объект, который мы будем спавнить
    public Transform[] spawnPoints; // Массив из трех точек спавна

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("tomato"))
        {
            ScoreManager.score++;
            Destroy(collision.gameObject);

            // Выбираем случайный индекс из массива точек спавна
            int randomIndex = Random.Range(0, spawnPoints.Length);

            // Получаем случайную точку спавна
            Vector2 randomSpawnPosition = spawnPoints[randomIndex].position;

            // Создаем новый объект в указанных координатах
            Instantiate(objectToSpawn, randomSpawnPosition, Quaternion.identity);
        }
    }
}
