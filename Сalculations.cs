using System;

namespace kr_sii
{
    public static class Сalculations
    {
        public static double ConvertToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        public static double GetSide(string type, Data data)
        {
            if (type == "side")
                return data.speedWave - data.lengthWave / (1.2 * data.periodT);

            if (type == "sideP")
                return data.speedWave - data.lengthWave / (2.0 * data.periodT);

            if (type == "keel")
                return data.speedWave - data.lengthWave / (1.2 * data.periodP);

            return double.MinValue;
        }

        public static double GetWidth(string type, Data data)
        {
            if (type == "side")
                return (data.speedWave - data.lengthWave 
                    / (1.2 * data.periodT)) - (data.speedWave - data.lengthWave / (0.8 * data.periodT));

            if (type == "sideP")
                return (data.speedWave - data.lengthWave 
                    / (2.0 * data.periodT)) - (data.speedWave - data.lengthWave / (1.9 * data.periodT));

            if (type == "keel")
                return (data.speedWave - data.lengthWave 
                    / (1.2 * data.periodP)) - (data.speedWave - data.lengthWave / (0.8 * data.periodP));

            return double.MinValue;
        }
    }
}
