using AprioriAlgorithm.DataProvider;

namespace AprioriAlgorithm
{
    using System.Collections.Generic;

    public interface IApriori
    {
        Output ProcessTransaction(double minSupport, double minConfidence, IEnumerable<string> items, string[] transactions);

        Output ProcessTransaction2(double minSupport, double minConfidence, IEnumerable<string> items, DrillData transactions);
    }
}