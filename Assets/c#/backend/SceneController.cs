
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class SceneController : MonoBehaviour
{
    public void ChooseScene(int a)                  // Метод смены сцены с номером сцены
    {
        SceneManager.LoadScene(a);                  // Выбор сцены (а может быть сценой 1, 2, 3 и т.д. - ну, там build setting и тд)
    }

    public void Exit()                              // Метод выхода из приоложения
    {
        Application.Quit();                         // Сам выход
    }

    // Хей, бро, спасибо, что посмотрел видеоролик! 
    // Подписывайся на канад ICE CREAM и до новых встрел на просторах YouTube!
}

