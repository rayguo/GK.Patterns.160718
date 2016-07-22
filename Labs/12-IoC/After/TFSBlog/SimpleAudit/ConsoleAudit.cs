
using System;

using Audit;

namespace SimpleAudit
{
   public class ConsoleAudit : IAudit
   {
      #region IAudit Members

      public void Message( string message )
      {
         Console.WriteLine( message );
      }

      #endregion
   }
}
