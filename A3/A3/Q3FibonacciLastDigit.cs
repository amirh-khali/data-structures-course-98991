﻿using System;
using TestCommon;

namespace A3
{
    public class Q3FibonacciLastDigit : Processor
    {
        public Q3FibonacciLastDigit(string testDataName) : base(testDataName) { }

        public override string Process(string inStr) =>
            TestTools.Process(inStr, (Func<long, long>)Solve);

        public long Solve(long n)
        {
            int a, b;
            a = 0;
            b = 1;
            for (int i = 1; i <= n; ++i) {
                int c = (a + b) % 10;
                a = b;
                b = c;
            }
            return a;
        }
    }
}
