using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnderControl
{
    public class Number
    {
        // The actual value of the number to be used
        private int numberValue;

        // All possible operations to be used on the number
        public enum Operations
        {
            Summation,
            Subtraction,
            Multiplication,
            Division
        }

        // Integer array holding available operations on the number
        // 1 for active, 0 for available, -1 for locked
        // e.g. [1, 0, 0, -1] -> Only summation is active, division is locked
        private int[] availableOperations;

        // Constructor with 0 active operations
        public Number(int numberValue)
        {
            this.numberValue = numberValue;
            availableOperations = new int[4] { 0, 0, 0, 0 };
        }

        // Deactivate all operations and activate the selected operation
        public void ActivateOperation(Operations operations)
        {
            for (int opIndex = 0; opIndex < availableOperations.Length; opIndex++)
            {
                // Make all actions available if they are not locked
                if (availableOperations[opIndex] != -1)
                {
                    availableOperations[opIndex] = 0;
                }
            }

            // Activate the selected operation
            availableOperations[(int)operations] = 1;
        }

        // Apply the active operation to the result
        public int InteractWithResult(int resultNumber)
        {
            // Get the currently active operation
            int activeOp = -1;
            for (int opIndex = 0; opIndex < availableOperations.Length; opIndex++)
            {
                if (availableOperations[opIndex] == 1)
                {
                    activeOp = opIndex;
                }
            }

            // Apply the active operation to the result and return it
            if ((int)Operations.Summation == activeOp)
            {
                resultNumber += numberValue;
            }
            else if ((int)Operations.Subtraction == activeOp)
            {
                resultNumber -= numberValue;
            }
            else if ((int)Operations.Multiplication == activeOp)
            {
                resultNumber *= numberValue;
            }
            else if ((int)Operations.Division == activeOp)
            {
                // TODO: Check if this is working as intended
                // Integer division
                resultNumber /= numberValue;
            }
            else
            {
                throw new System.Exception("No active operation.");
            }

            return resultNumber;
        }

        public int GetValue()
        {
            return numberValue;
        }
    }
}
