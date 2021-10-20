using System;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public float FirstNumber { get; set; }
        public float SecondNumber { get; set; }

        public float Add() => FirstNumber + SecondNumber;

        public float Subtract() => FirstNumber - SecondNumber;

        public float Multiply() => FirstNumber * SecondNumber;
        public float Divide() 
        {
            if (SecondNumber == 0) 
            {
                throw new DivideByZeroException();
            }
            else
            {
                return (float)FirstNumber / (float)SecondNumber;
            }
        }

        public float Mod() => FirstNumber % SecondNumber;
    }
}