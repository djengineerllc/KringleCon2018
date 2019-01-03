using System;
using Caliburn.Micro;

namespace KringleCon2018
{
    public class OpenWindowMessage
    {
        public OpenWindowMessage(Screen screen) => Screen = screen;
        /// <summary>
        /// Gets or sets the screen to switch to
        /// </summary>
        public Screen Screen { get; set; }
    }
}