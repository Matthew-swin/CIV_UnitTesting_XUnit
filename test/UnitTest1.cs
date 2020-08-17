using System;
using Xunit;
using CalcLib;

namespace test
{
    public class UnitTest1
    {
        RecursiveCalc a = new RecursiveCalc();

        [Fact]
        public void Test1()
        {
            Assert.Equal(2,a.FactorialRec(1,2));
            Assert.Equal(524160,a.FactorialRec(8,13));
        }

        [Theory]
        [InlineData(false,1)]
        [InlineData(false,50)]
        public void Test2(Boolean expected,int num)
        {

          Assert.Equal(expected,a.FibCheck(num));
        }

        [Fact]
        public void Test3()
        {
         Assert.Throws<DivideByZeroException>(() => a.PrimeCheckRec(5,0));   
        }

        [Theory]
        [InlineData(99,1,2,4)]
        [InlineData(2019,45,6,4)]
        public void Test4(int expected,int num1, int num2, int numFibs)
        {
         Assert.Equal(expected,a.FibonacciRec(num1, num2, numFibs));
        }



 
    }
}
