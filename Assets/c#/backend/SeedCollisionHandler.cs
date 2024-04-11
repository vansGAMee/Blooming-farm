using UnityEngine;
using System.Collections;

public class SeedCollisionHandler : MonoBehaviour
{
    public GameObject prefabToSpawn; // Префаб объекта, в который превращаем семечко
    private bool triggered; // Флаг, указывающий, что объект уже сработал

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!triggered && other.CompareTag("seed"))
        {
            triggered = true; // Устанавливаем флаг, чтобы избежать повторных срабатываний
            Debug.Log("Seed triggered with " + gameObject.name); // Выводим сообщение о срабатывании в консоль
            StartCoroutine(GrowTreeAfterDelay(other.gameObject));
        }
    }

    IEnumerator GrowTreeAfterDelay(GameObject triggeredSeed)
    {
        yield return new WaitForSeconds(3f); // Ждем 3 секунды

        if (prefabToSpawn != null)
        {
            // Создаем новый объект из префаба
            GameObject newObject = Instantiate(prefabToSpawn, triggeredSeed.transform.position, Quaternion.identity);
            Debug.Log("Tree spawned at " + triggeredSeed.transform.position); // Выводим сообщение о создании нового объекта в консоль
        }
        else
        {
            Debug.LogError("Prefab to spawn is not assigned in SeedTriggerHandler script on object: " + gameObject.name);
        }

        // Уничтожаем семечко
        Destroy(triggeredSeed.gameObject);

        triggered = false; // Сбрасываем флаг, чтобы в будущем снова реагировать на срабатывания
    }
}
