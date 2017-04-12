﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Halley
{
    class MyButton : System.Windows.Forms.Button
    {
        protected override bool ProcessDialogKey(Keys key)
        {
            switch (key)
            {
                case (Keys.Left):
                case (Keys.Right):
                case (Keys.Down):
                case (Keys.Up):
                case (Keys.Enter):
                    return false;
            }
            return base.ProcessDialogKey(key);

        }
    }
}
