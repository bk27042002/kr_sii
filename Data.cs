using System;

namespace kr_sii
{
    public class Data
    {
        // Вариант 3
        // Параметры корабля
        public double lengthShip = 50;  // Длина
        public double widthShip = 8.5; // Ширина
        public double draftShip = 3.6; // Осадка 
        public double metaHeight = 0.55;// Метацентрическая высота
        public double speedShip = 12; // Скорость 
        public double lengthWave = 50;  // Длина волны (lengthShip)
        public double T = 15;  // Амплитуда бортовой качки
        public double P = 3;   // Амплитуда килевой качки

        // Исходные вероятности
        public const double PE = 0.74;
        public const double PHE = 0.89;
        public const double PHNOTE = 0.01;
        public const double MDHE1 = 0.89;
        public const double MDHE2 = 0.97;

        // Получаемые данные
        public double speedWave; // Скорость волны
        public double periodWave; // Период волны
        public double periodT; // Период бортовой качки
        public double periodP; // Период килевой качки

        public double _T; // Амплитуда бортовой качки
        public double _P; // Амплитуда килевой качки
        public double angle; // Курсовой угол

        // Формула Байеса
        public const double Bayes = PHE * PE + PHNOTE * (1 - PE) + (1 - PHE) * PE + PHE * (1 - PE);

        // формула Шортлиффа
        public const double Shortliff = MDHE1 + MDHE2 * (1 - MDHE1);                  

        public Data()
        {
            speedWave = 1.25 * Math.Pow(lengthWave, 0.5);
            periodT = 0.8 * widthShip / Math.Pow(metaHeight, 0.5);
            periodP = 2.5 * Math.Pow(draftShip, 0.5);
        }

        public void SetData(double angle, double P, double T)
        {
            _T = T;
            _P = P;
            this.angle = angle;
            periodWave = lengthWave / (speedWave - speedShip * Math.Cos(Сalculations.ConvertToRadian(this.angle)));
        }

    }
}