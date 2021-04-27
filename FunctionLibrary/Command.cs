using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary.Interfaces;

namespace FunctionLibrary
{
    /// <summary>
    /// Author: Benedict Gardner
    /// 
    /// Command classes, which each handle differing
    /// amounts of parameters passed through into it.
    /// 
    /// Chose to keep all command classes in a single
    /// file rather than have plethora of class files
    /// each with slightly different variations of 
    /// the word command.
    /// 
    /// Code Snippet: Setup and execution of commands
    /// Modified from: https://dotnettutorials.net/lesson/command-design-pattern/
    /// </summary>
    public class Command : ICommand
    {
        private Action _action;

        public Command(Action pAction)
        {
            _action = pAction;
        }

        public void Execute()
        {
            _action();
        }
    }
    /// <summary>
    /// Command class of one paramater "A"
    /// </summary>
    /// <typeparam name="A"></typeparam>
    public class Command<A> : ICommand
    {
        private Action<A> _action;

        private A _data;

        public Command(Action<A> pAction, A pData)
        {
            _action = pAction;
            _data = pData;
        }

        public void Execute()
        {
            _action(_data);
        }
    }

    public class Command<A, B> : ICommand
    {
        private Action<A, B> _action;

        private A _dataA;

        private B _dataB;

        public Command(Action<A,B> pAction, A pDataA, B pDataB)
        {
            _action = pAction;
            _dataA = pDataA;
            _dataB = pDataB;
        }

        public void Execute()
        {
            _action(_dataA, _dataB);
        }
    }
    public class Command<A, B, C> : ICommand
    {
        private Action<A, B, C> _action;

        private A _dataA;

        private B _dataB;

        private C _dataC;

        public Command(Action<A, B, C> pAction, A pDataA, B pDataB, C pDataC)
        {
            _action = pAction;
            _dataA = pDataA;
            _dataB = pDataB;
            _dataC = pDataC;
        }

        public void Execute()
        {
            _action(_dataA, _dataB, _dataC);
        }
    }
    public class Command<A, B, C, D> : ICommand
    {
        private Action<A, B, C, D> _action;

        private A _dataA;

        private B _dataB;

        private C _dataC;

        private D _dataD;

        public Command(Action<A, B, C, D> pAction, A pDataA, B pDataB, C pDataC, D pDataD)
        {
            _action = pAction;
            _dataA = pDataA;
            _dataB = pDataB;
            _dataC = pDataC;
            _dataD = pDataD;
        }

        public void Execute()
        {
            _action(_dataA, _dataB, _dataC, _dataD);
        }
    }

    public class Command<A, B, C, D, E> : ICommand
    {
        private Action<A, B, C, D, E> _action;

        private A _dataA;

        private B _dataB;

        private C _dataC;

        private D _dataD;

        private E _dataE;

        public Command(Action<A, B, C, D, E> pAction, A pDataA, B pDataB, C pDataC, D pDataD, E pDataE)
        {
            _action = pAction;
            _dataA = pDataA;
            _dataB = pDataB;
            _dataC = pDataC;
            _dataD = pDataD;
            _dataE = pDataE;
        }

        public void Execute()
        {
            _action(_dataA, _dataB, _dataC, _dataD, _dataE);
        }
    }
}
