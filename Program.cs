

namespace Lesson
{

    /*
     * Boxing and unboxing
     */

    class Program
    {
        public static void Main(string[] args)
        {
            int a = 1; // int it's a struct (структура - это значимые типы и значит данные раположены на стеке)
            object b = a; // object базовый класс (размещается в управляемой куче); выделяем место в управтляемой куче и копируем туда данные с переменной а, взамен в переменной b получаем ссылку на эти данные в управляемой куче (вотт и упакована переменная типа int)
            int c =(int)b; // извлекаем эти данные из переменной b в переменную с. (распаковка)
            
        }
    }
}