using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class ArithProgression : ISeries
    {
        int stepArif;
        int startValue;
        int currentValue;
        public int getNext()
        {
            currentValue += stepArif;
            return currentValue;
        }

        public void reset()
        {
            currentValue = startValue;
        }

        public void setStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }
        public void setStep(int x)
        {
            stepArif = x;
        }
    }

}
