namespace Kharyushin_ISP01
{
    class Banknote
    {
        public int Series { get; set; }
        public int Nominal { get; set; }
        public string NominalString { get; set; }

        public Banknote(int series, int nominal, string nominalstring)
        {
            Series = series;
            Nominal = nominal;
            NominalString = nominalstring;
        }

        public override string ToString()
        {
            return $"Серия: {Series}; Номинал: {Nominal}; Номинал прописью: {NominalString}";
        }
    }
}
