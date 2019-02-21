using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Units
{
    public class Unit
    {
        static double lbf = 4.4482216;
        static double klbf = 4448.2216;
        static double N = 1.0;
        static double kN = 1000.0;
        static double MN = 1000000.0;
        static double daN = 10.0;
        static double kgf = 9.80665;
        static double gf = .00980665;
        static double lbfin = 0.1129847753;
        static double lbfft = 1.3558179483;
        static double klbfin = 112.9847753;
        static double klbfft = 1355.8179483;
        static double Nm = 1.0;
        static double kNm = 1000.0;

        public static Dictionary<string, double> unit = new Dictionary<string, double>()
        {
            {"lbf", lbf}, {"LBF", lbf}, {"lb", lbf}, {"LB", lbf}, {"lbs", lbf}, {"LBS", lbf},
            {"klbf", klbf}, {"KLBF", klbf}, {"Klbf", klbf}, {"K", klbf}, {"k", klbf }, {"klb", klbf}, {"KLB", klbf}, {"Klb", klbf }, {"klbs", klbf}, {"KLBS", klbf}, {"Klbs", klbf},
            {"N", N}, {"n", N},
            {"kN", kN}, {"KN", kN }, {"kn", kN}, {"Kn", kN},
            {"MN", MN}, {"Mn", MN}, // do not allow lower case m to be used. m = milli, M = Mega
            {"daN", daN}, {"DAN", daN}, {"DaN", daN}, {"dan", daN}, {"DAn", daN},
            {"kgf", kgf}, {"KGF", kgf}, {"Kgf", kgf}, {"kg", kgf}, {"KG", kgf}, {"Kg", kgf}, {"kG", kgf}, {"kGF", kgf},
            {"gf", gf}, {"GF", gf}, {"g", gf}, {"G", gf}, {"Gf", gf}, {"gF", gf},
            {"lbf*in", lbfin}, {"LBF*IN", lbfin}, {"lbfin", lbfin}, {"LBFIN", lbfin}, {"lb*in", lbfin}, {"LB*IN", lbfin}, {"lbin", lbfin}, {"LBIN", lbfin},
            {"klbf*in", klbfin}, {"kLBF*IN", klbfin}, {"klbfin", klbfin}, {"kLBFIN", klbfin}, {"klb*in", klbfin}, {"kLB*IN", klbfin}, {"klbin", klbfin}, {"kLBIN", klbfin},
            {"Klbf*in", klbfin}, {"KLBF*IN", klbfin}, {"Klbfin", klbfin}, {"KLBFIN", klbfin}, {"Klb*in", klbfin}, {"KLB*IN", klbfin}, {"Klbin", klbfin}, {"KLBIN", klbfin},
            {"Nm", Nm}, {"NM", Nm }, {"nm", Nm}, {"nM", Nm}, // I was hesitant to allow lower-case n to be use (n = nano in SI), but since these are all load units, it should be fine
            {"kNm", kNm}, {"kNM", kNm }, {"knm", kNm}, {"knM", kNm}, {"KNm", kNm}, {"KNM", kNm }, {"Knm", kNm}, {"KnM", kNm}
        };

        public static double Ratio(string unit_1, string unit_2)
        {
            return unit[unit_1] / unit[unit_2];
        }
    }
}
