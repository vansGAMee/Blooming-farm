// В скрипте playercontroller.cs добавьте следующий код для движения игрока во все стороны:

using UnityEngine;

public class move : MonoBehaviour

{
    void Update()
    {
        float speed = 5f; // Скорость движения

        // Движение вверх и вниз
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(0f, verticalInput * speed * Time.deltaTime, 0f);

        // Движение влево и вправо
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(horizontalInput * speed * Time.deltaTime, 0f, 0f);
    }
}




