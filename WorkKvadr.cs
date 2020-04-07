using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MotionDetectorSample
{
    /// <summary>
    ///Класс для удаления лишних квадратов
    /// </summary>
    class WorkKvadr
    {
        /// <summary>
        /// Главная функция
        /// </summary>
        public Rectangle[] main(Rectangle[] a)
        {
            Rectangle[] kvadr = a;
            for (int i=0;i<kvadr.Length;i++)
            {
                for (int j = i+1; j < kvadr.Length; j++)
                {

                }
            }
            return kvadr;
        }
        /// <summary>
        /// Определение пересечений квадратов
        /// </summary>
        //public bool TimeNotWork()
        //{
           
        //}
    }
}
