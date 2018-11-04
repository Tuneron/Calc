using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Calculate
    {
        private float numberOne;
        private float numberTwo;
        private bool numberSwitch;
        private int operation;
        private bool RecordStop;

        public Calculate ()
        {
            numberOne = 0;
            numberTwo = 0;
            numberSwitch = true;
            operation = 0;
            RecordStop = true;
        }

        public bool GetRecordContinue()
        {
            return RecordStop;
        }

        public void ResetCalc()
        {
            numberOne = 0;
            numberTwo = 0;
            numberSwitch = true;
            operation = 0;
            RecordStop = true;
        }

        public void RecordNumer(float number)
        {
            if(numberSwitch)
            numberOne = numberOne * 10 + number;
            else
                numberTwo = numberTwo * 10 + number;
        }

        public float GetNumber()
        {
            if (numberSwitch)
                return numberOne;
            else
                return numberTwo;
        }

        public void ChangeNumber()
        {
            numberSwitch = false;
            numberTwo = 0;
        }

        public void SetOperation(int count)
        {
            RecordStop = true;
            operation = count; 
        }

        public float getResult()
        {
            switch (operation)
                {
                case 1:
                    {
                        RecordStop = false;
                        numberOne += numberTwo;
                        return numberOne;
                    }
                    break;
                case 2:
                    {
                        RecordStop = false;
                        numberOne -= numberTwo;
                        return numberOne;
                    }
                    break;
                case 3:
                    {
                        RecordStop = false;
                        numberOne *= numberTwo;
                        return numberOne;
                    }
                    break;
                case 4:
                    {
                        RecordStop = false;
                        numberOne /= numberTwo;
                        return numberOne;
                    }
                    break;
                case 5:
                    {
                        RecordStop = false;
                        numberOne = (float)Math.Pow(numberOne, 0.5);
                        return numberOne;
                    }
                    break;
                default:
                    {
                        return 404;
                    }
            }
        }
    }
}
