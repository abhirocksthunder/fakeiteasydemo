using System;
using System.Collections.Generic;
using System.Text;

namespace InterestTestCases
{
    public interface IMaths
    {
        double Multiply(double a, double b);
        double Add(double a, double b);
        double Substract(double a, double b);
        double Divide(double a, int b);
    }
}
