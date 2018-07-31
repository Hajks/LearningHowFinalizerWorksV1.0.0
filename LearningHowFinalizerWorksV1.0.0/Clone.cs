using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningHowFinalizerWorksV1._0._0
{
    class Clone : IDisposable
    {
        public int Id { get; private set; }

        public Clone(int Id)
        {
            this.Id = Id;
        }

        public void Dispose()
        {
            MessageBox.Show("Zostałem usunięty!", "Klon " + Id + ". mówi...");
        }

        ~Clone()
        {
            MessageBox.Show("Aaaaaaa! Dopadłeś mnie!", "Klon " + Id + ". mówi...");
        }
    }
}
