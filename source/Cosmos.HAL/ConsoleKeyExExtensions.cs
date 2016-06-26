﻿using System;

namespace Cosmos.HAL
{
    public static class ConsoleKeyExExtensions
    {
        public static ConsoleKey ToConsoleKey(this ConsoleKeyEx keyEx)
        {
            switch (keyEx)
            {
                case ConsoleKeyEx.NoName:
                    return ConsoleKey.NoName;
                case ConsoleKeyEx.Escape:
                    return ConsoleKey.Escape;
                case ConsoleKeyEx.F1:
                    return ConsoleKey.F1;
                case ConsoleKeyEx.F2:
                    return ConsoleKey.F2;
                case ConsoleKeyEx.F3:
                    return ConsoleKey.F3;
                case ConsoleKeyEx.F4:
                    return ConsoleKey.F4;
                case ConsoleKeyEx.F5:
                    return ConsoleKey.F5;
                case ConsoleKeyEx.F6:
                    return ConsoleKey.F6;
                case ConsoleKeyEx.F7:
                    return ConsoleKey.F7;
                case ConsoleKeyEx.F8:
                    return ConsoleKey.F8;
                case ConsoleKeyEx.F9:
                    return ConsoleKey.F9;
                case ConsoleKeyEx.F10:
                    return ConsoleKey.F10;
                case ConsoleKeyEx.F11:
                    return ConsoleKey.F11;
                case ConsoleKeyEx.F12:
                    return ConsoleKey.F12;
                case ConsoleKeyEx.PrintScreen:
                    return ConsoleKey.PrintScreen;
                case ConsoleKeyEx.D1:
                    return ConsoleKey.D1;
                case ConsoleKeyEx.D2:
                    return ConsoleKey.D2;
                case ConsoleKeyEx.D3:
                    return ConsoleKey.D3;
                case ConsoleKeyEx.D4:
                    return ConsoleKey.D4;
                case ConsoleKeyEx.D5:
                    return ConsoleKey.D5;
                case ConsoleKeyEx.D6:
                    return ConsoleKey.D6;
                case ConsoleKeyEx.D7:
                    return ConsoleKey.D7;
                case ConsoleKeyEx.D8:
                    return ConsoleKey.D8;
                case ConsoleKeyEx.D9:
                    return ConsoleKey.D9;
                case ConsoleKeyEx.D0:
                    return ConsoleKey.D0;
                case ConsoleKeyEx.Backspace:
                    return ConsoleKey.Backspace;
                case ConsoleKeyEx.Tab:
                    return ConsoleKey.Tab;
                case ConsoleKeyEx.Q:
                    return ConsoleKey.Q;
                case ConsoleKeyEx.W:
                    return ConsoleKey.W;
                case ConsoleKeyEx.E:
                    return ConsoleKey.E;
                case ConsoleKeyEx.R:
                    return ConsoleKey.R;
                case ConsoleKeyEx.T:
                    return ConsoleKey.T;
                case ConsoleKeyEx.Y:
                    return ConsoleKey.Y;
                case ConsoleKeyEx.U:
                    return ConsoleKey.U;
                case ConsoleKeyEx.I:
                    return ConsoleKey.I;
                case ConsoleKeyEx.O:
                    return ConsoleKey.O;
                case ConsoleKeyEx.P:
                    return ConsoleKey.P;
                case ConsoleKeyEx.Enter:
                    return ConsoleKey.Enter;
                case ConsoleKeyEx.A:
                    return ConsoleKey.A;
                case ConsoleKeyEx.S:
                    return ConsoleKey.S;
                case ConsoleKeyEx.D:
                    return ConsoleKey.D;
                case ConsoleKeyEx.F:
                    return ConsoleKey.F;
                case ConsoleKeyEx.G:
                    return ConsoleKey.G;
                case ConsoleKeyEx.H:
                    return ConsoleKey.H;
                case ConsoleKeyEx.J:
                    return ConsoleKey.J;
                case ConsoleKeyEx.K:
                    return ConsoleKey.K;
                case ConsoleKeyEx.L:
                    return ConsoleKey.L;
                case ConsoleKeyEx.Z:
                    return ConsoleKey.Z;
                case ConsoleKeyEx.X:
                    return ConsoleKey.X;
                case ConsoleKeyEx.C:
                    return ConsoleKey.C;
                case ConsoleKeyEx.V:
                    return ConsoleKey.V;
                case ConsoleKeyEx.B:
                    return ConsoleKey.B;
                case ConsoleKeyEx.N:
                    return ConsoleKey.N;
                case ConsoleKeyEx.M:
                    return ConsoleKey.M;
                case ConsoleKeyEx.Spacebar:
                    return ConsoleKey.Spacebar;
                case ConsoleKeyEx.Insert:
                    return ConsoleKey.Insert;
                case ConsoleKeyEx.Home:
                    return ConsoleKey.Home;
                case ConsoleKeyEx.PageUp:
                    return ConsoleKey.PageUp;
                case ConsoleKeyEx.Delete:
                    return ConsoleKey.Delete;
                case ConsoleKeyEx.End:
                    return ConsoleKey.End;
                case ConsoleKeyEx.PageDown:
                    return ConsoleKey.PageDown;
                case ConsoleKeyEx.UpArrow:
                    return ConsoleKey.UpArrow;
                case ConsoleKeyEx.DownArrow:
                    return ConsoleKey.DownArrow;
                case ConsoleKeyEx.LeftArrow:
                    return ConsoleKey.LeftArrow;
                case ConsoleKeyEx.RightArrow:
                    return ConsoleKey.RightArrow;
                case ConsoleKeyEx.Sleep:
                    return ConsoleKey.Sleep;
                case ConsoleKeyEx.BiggerThan:
                case ConsoleKeyEx.Period:
                    return ConsoleKey.OemPeriod;
                case ConsoleKeyEx.LowerThan:
                case ConsoleKeyEx.Comma:
                    return ConsoleKey.OemComma;
                case ConsoleKeyEx.NumPeriod:
                    return ConsoleKey.Decimal;
                case ConsoleKeyEx.NumPlus:
                    return ConsoleKey.Add;
                case ConsoleKeyEx.NumEnter:
                    return ConsoleKey.Enter;
                case ConsoleKeyEx.Backslash:
                    return ConsoleKey.Oem5;
                case ConsoleKeyEx.LBracket:
                    return ConsoleKey.Oem4;
                case ConsoleKeyEx.RBracket:
                    return ConsoleKey.Oem6;
                case ConsoleKeyEx.Minus:
                    return ConsoleKey.OemMinus;
                case ConsoleKeyEx.Apostrophe:
                    return ConsoleKey.Oem7;
                case ConsoleKeyEx.Slash:
                    return ConsoleKey.Oem2;
                case ConsoleKeyEx.Equal:
                    return ConsoleKey.OemPlus;
                case ConsoleKeyEx.Backquote:
                    return ConsoleKey.Oem3;
                case ConsoleKeyEx.Semicolon:
                case ConsoleKeyEx.Colon:
                    return ConsoleKey.Oem1;
                default:
                    throw new Exception("KeyEx not implemented!");
            }
        }
    }
}