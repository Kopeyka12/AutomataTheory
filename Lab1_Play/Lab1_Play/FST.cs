using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Lab1_Play
{
    public class FST
    {
        private Action activeState; // указатель на активное состояние автомата

        public FST()
        {

        }

        public void SetState(Action state)
        {
            activeState = state;
        }

        public void Update()
        {
            activeState?.Invoke();
        }
    }
}

