﻿using System.IO;

namespace Cs.Lib.Abstracts
{
    public interface ISarjorlu
    {
        int SarjorKapasitesi { get; }
        int KalanFisek { get; }
        int YenidenDoldur();
        
        Stream YenidenDoldurmaSesi { get; }
    }
}