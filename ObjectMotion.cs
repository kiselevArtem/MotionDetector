using AForge;
using System;
using System.Collections.Generic;


namespace MotionDetectorSample
{
    class Car
    {
        /// <summary>
        /// Центр координат машины
        /// </summary>
        public List<Point> Route = new List<Point>();
        /// <summary>
        ///Состояние показывающее  Отслеживается ли данная машина
        /// </summary>
        public bool SostWork=true ;
        /// <summary>
        /// Состояние показывающее отслеживалась ли мишина на последнем кадре
        /// </summary>
        public bool SostTime = true;
        /// <summary>
        /// Количество кадров на которых машина не отслеживалась
        /// </summary>
        public int kolvo = 0;

        public void izmenSost()
        {
            if (kolvo > 60)
                SostWork = false;           
        }

        public void TimeNotWork()
        {
            kolvo++;
            if (kolvo > 60)
                SostWork = false;
        }
    }
  

}
