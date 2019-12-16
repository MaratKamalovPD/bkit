using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework
{
    
    public class ParallelSearchResult /// Результаты параллельного поиска
    {
        
        public string word { get; set; } /// Найденное слово

        
        public int dist { get; set; }  /// Расстояние

        
        public int ThreadNum { get; set; } /// Номер потока
    }
}
