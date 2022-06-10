using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDeskAdmin.CustomControls
{
    public class CTextBox : TextBox
    {
        public CTextBox()
        {
            CharacterCasing = CharacterCasing.Upper;
            MaxLength = 256;
        }
    }
}
