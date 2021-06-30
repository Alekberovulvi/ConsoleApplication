using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Interface
{
    interface IMarketable
    {
        public void Saless(int number, int sum, DateTime dateTime);
        public void Products();
        public void SatisElaveEtmek();
        public void SatisdanMehsulunGeriQaytarilmasi();
        public void UmumiSatisinGeriQaytarilmasi();
        public void Verilentarixaraliginagorehemintarixaraliginaolansatislarinqaytarilmasi();
        public void Verilenbirtarixegorehemintarixucunolansatislarinqaytarilmasi();

    }
}
