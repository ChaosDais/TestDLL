using UnityEngine;
using System.Diagnostics;
using System;

namespace TestManagedPlugin
{
    public class Sorter : MonoBehaviour
    {
        public int[] a;

        private void Start()
        {
            MeasureFunctionExecutionTime();
        }

        void MeasureFunctionExecutionTime()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            TestFunction();
            stopwatch.Stop();

            long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
            UnityEngine.Debug.Log($"Managed plugin took {elapsedMilliseconds} ms to execute");
        }

        void TestFunction()
        {
            TestSort(a);
        }

        void TestSort(int[] a)
        {
            Array.Sort(a);
        }
    }
}
