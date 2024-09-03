namespace kr_sii
{
    class Conclusions
    {
        Data data = new Data();
        Charting charting = new Charting(542,520,80,16, @"..\..\Chart\Image.jpg");

        internal void GetData(double course, double psi, double teta)
        {
            data.SetData(course, psi, teta);
        }

        internal string GetPitchingType()
        {
            if (MainBoardPitching()) 
                return "Бортовая качка";

            if (ParamBoardPitching()) 
                return "Параметрическая качка";

            if (MainPitching()) 
                return "Килевая качка";
            
            return "Без качки";
        }

        internal System.Drawing.Image GetChart()
        {
            double side = Сalculations.GetSide("side",data);
            double sideP = Сalculations.GetSide("sideP", data);
            double keel = Сalculations.GetSide("keel", data);
            double width = Сalculations.GetWidth("side",data);
            double widthP = Сalculations.GetWidth("sideP", data);
            double keelWidth = Сalculations.GetWidth("keel", data);

            return charting.DrawChart(side, sideP, keel, width, widthP, keelWidth, data) ;
        }
        private bool MainBoardPitching()
        {
            return (data._T > data.T) && (data.periodWave / data.periodT > 0.8) 
                && (data.periodWave / data.periodT < 1.2);
        }
        private bool ParamBoardPitching()
        {
            return (data._T > data.T) && (data.periodWave / data.periodT > 1.95) 
                && (data.periodWave / data.periodT < 2.05);
        }
        private bool MainPitching()
        {
            return (data._P > data.P) && (data.periodWave / data.periodP > 0.8) 
                && (data.periodWave / data.periodP < 1.2);
        }
    }
}
