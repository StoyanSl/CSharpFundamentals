﻿using System;
using System.Collections.Generic;
using System.Text;
using BashSoftProgram.Exceptions;

namespace BashSoftProgram.IO.Commands
{
    class ChangeRelativePathCommand:Command
    {
        public ChangeRelativePathCommand(string input, string[] data, Tester tester, StudentRepository repo, IOManager iOManager) : base(input, data, tester, repo, iOManager)
        {

        }
        public override void Execute()
        {
            if (Data.Length == 2)
            {
                string relPath = Data[1];
                InputOutputManager.ChangeCurrentDirectoryRelative(relPath);
            }
            
            else
            {
                throw new InvalidCommandException(this.Input);
            }
        }
    }
}
