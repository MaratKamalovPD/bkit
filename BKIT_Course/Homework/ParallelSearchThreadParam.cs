using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework
{
    
    class ParallelSearchThreadParam /// Параметры которые передаются в поток для параллельного поиска
    {
        
        public List<string> tempList { get; set; } /// Массив для поиска

        
        public string wordPattern { get; set; } /// Слово для поиска

        
        public int maxDist { get; set; } /// Максимальное расстояние для нечеткого поиска

        
        public int ThreadNum { get; set; } /// Номер потока
    }
}
