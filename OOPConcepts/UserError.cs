using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    internal abstract class UserError
    {
        public abstract string UEMessage();
    }

    internal class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }

    internal class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }

    internal class EmailInputError : UserError
    {
        public override string UEMessage()
        {
            return "The email you entered was not in an email format!";
        }
    }

    internal class OmitInputError : UserError
    {
        public override string UEMessage()
        {
            return "You forgot to enter information in a required field!";
        }
    }
    internal class DateInputError : UserError
    {
        public override string UEMessage()
        {
            return "The date you entered was outside of the required range!";
        }
    }
}
