using System;

namespace Todo_List_App_WinForms
{
    public static class CustomExceptionHandler
    {

        //exception 1
        public static void HandlePastTimeSet()
        {
            MessageBox.Show(
                "Встановлено час у минулому. Вкажіть майбутній час.",
                "Помилка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        //exception 2
        public static void HandleNoTasksFound()
        {
            MessageBox.Show(
                "Нічого не знайдено за вашим запитом.",
                "Помилка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        //exception 3
        public static void HandleEmptySearchField()
        {
            MessageBox.Show(
             "Поле пошуку не повинно бути порожнім.",
               "Помилка",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information
           );
          
        }

        //exception 4
        public static void HandleNoTypeSelectedForFilter()
        {
            MessageBox.Show(
             "Виберіть тип для фільтрації!",
               "Помилка",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information
           );
            
        }

        //exception 5
        public static void HandleEmptyField()
        {
            MessageBox.Show(
                "Назва обов'язкова!",
                "Помилка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // exception 6
        public static void HandleShortTaskName()
        {
            MessageBox.Show(
                "Назва повинна бути не менше 3 символів!",
                "Помилка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // exception 7 
        public static void HandleLongTaskName()
        {
            MessageBox.Show(
                "Назва повинна бути не більше 10 символів!",
                "Помилка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        //exception 8
        public static void HandleInvalidTaskType()
        {
            MessageBox.Show(
                "Виберіть тип задачі!",
                "Помилка",
                MessageBoxButtons.OK,
               MessageBoxIcon.Information
            );
        }

        // exception 9
        public static void HandleUnfinishedTaskAddition(FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Ви впевнені, що хочете вийти? Здається, ви не завершили додавання задачі.",
                "Підтвердження",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        // exception 10
        public static void HandleTaskFileNotFoundError(string filePath)
        {
            MessageBox.Show(
                $"Файл з задачами не знайдено: {filePath}. Перевірте його наявність.",
                "Помилка",
                MessageBoxButtons.OK,
              MessageBoxIcon.Error
            );
        }
    }
}
