using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datenzugriff
{
    class IDTO
    {
        bool connect();
        bool benutzerAuslesen();
        bool benutzerAnlegen();
        bool benutzerAendern();
        bool benutzerUpdate();
        bool setAnlegen();
        void KartenAnzeigen();

    }
}
