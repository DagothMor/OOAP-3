using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAP_3
{
    public class Task5
    {
        // 1. То что было задумано ранее по факту паттерн Reactor (Класс EventPipeline обрабатывающий очередь событий(ввод пользователя, заполнение матрицы после взрыва, вывод анимаций...))
        // 2. EventSourcing, чтобы хранился порядок обработанных событий, и у нас была всегда актуальная матрица которую мы покажем и будем ожидать ввод пользователя
        // 3. Outbox - чтобы не возникали баги с дублированием обработки логики
    }
}
