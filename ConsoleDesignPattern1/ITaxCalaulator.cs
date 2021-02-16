using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDesignPattern1
{
    public interface ITaxCalaulator
    {
        float calculateHomeTax();
        float calculateCarTax();
    }
}
