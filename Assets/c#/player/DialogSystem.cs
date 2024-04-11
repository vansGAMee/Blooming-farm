using UnityEngine;
using UnityEngine.UI;

public class DialogSystem : MonoBehaviour
{
    public Text dialogText; // Ссылка на компонент Text для отображения диалога
    public string[] dialogs; // Массив строк с диалогами
    private int currentDialogIndex = 0; // Индекс текущего диалога

    void Start()
    {
        // Проверяем, есть ли какие-либо диалоги в массиве
        if (dialogs.Length > 0)
        {
            // Отображаем первый диалог
            dialogText.text = dialogs[currentDialogIndex];
        }
    }

    void Update()
    {
        // Проверяем, если была нажата клавиша пробела
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Переходим к следующему диалогу, если они еще есть
            if (currentDialogIndex < dialogs.Length - 1)
            {
                currentDialogIndex++;
                dialogText.text = dialogs[currentDialogIndex];
            }
            else
            {
                // Если это был последний диалог, заканчиваем диалоговую сессию
                EndDialog();
            }
        }
    }

    // Метод для завершения диалоговой сессии
    void EndDialog()
    {
        // Здесь вы можете выполнить любые действия, связанные с завершением диалога
        // Например, выключить окно диалога или активировать другую логику в вашей игре
        Debug.Log("Диалог завершен");
    }
}
